DELIMITER $$

CREATE TRIGGER blokiraj_duple_narudzbe
BEFORE INSERT ON narudzba
FOR EACH ROW
BEGIN
    DECLARE br_narudzbi INT DEFAULT 0;
    
    SELECT COUNT(*) INTO br_narudzbi
    FROM narudzba
    WHERE stol_id = NEW.stol_id
      AND zaprimljena = NEW.zaprimljena;
    
    IF br_narudzbi > 0 THEN
        SIGNAL SQLSTATE '45001'
        SET MESSAGE_TEXT = 'Već postoji identična narudžba!';
    END IF;
END$$

DELIMITER ;

DELIMITER $$

CREATE TRIGGER blokiraj_negativne_cijene
BEFORE INSERT ON artikl
FOR EACH ROW
BEGIN
    IF NEW.cijena < 0 THEN
        SIGNAL SQLSTATE '45002'
        SET MESSAGE_TEXT = 'Artikl ne može imati negativnu cijenu!';
    END IF;
END$$

DELIMITER ;

INSERT INTO artikl VALUES ()

DELIMITER $$

CREATE TRIGGER provjera_mjesta_stola
BEFORE INSERT ON stol
FOR EACH ROW
BEGIN
    IF NEW.mjesta < 1 THEN
        SIGNAL SQLSTATE '45003'
        SET MESSAGE_TEXT = 'Stol mora imati barem jedno mjesto!';
    END IF;
END$$

DELIMITER ;

DELIMITER $$

CREATE TRIGGER onemoguci_nedostupne_artikle
BEFORE INSERT ON stavka_narudzbe
FOR EACH ROW
BEGIN
    DECLARE dostupnost BOOLEAN;
    
    -- Provjeri je li artikl dostupan
    SELECT dostupan INTO dostupnost
    FROM artikl
    WHERE id = NEW.artikl_id;
    
    IF NOT dostupnost THEN
        SIGNAL SQLSTATE '45004'
        SET MESSAGE_TEXT = 'Artikl trenutno nije dostupan!';
    END IF;
END$$

DELIMITER ;

CREATE TABLE IF NOT EXISTS evidencija_cijena (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    artikl_id INTEGER NOT NULL,
    stara_cijena DECIMAL(8,2),
    nova_cijena DECIMAL(8,2),
    promijenio VARCHAR(100),
    vrijeme TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

DELIMITER $$

CREATE TRIGGER uvedi_u_evidenciju_cijena
AFTER UPDATE ON artikl
FOR EACH ROW
BEGIN
    IF NEW.cijena != OLD.cijena THEN
        INSERT INTO evidencija_cijena (artikl_id, stara_cijena, nova_cijena, promijenio)
        VALUES (OLD.id, OLD.cijena, NEW.cijena, USER());
    END IF;
END$$

DELIMITER ;



