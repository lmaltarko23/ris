CREATE TABLE kategorija (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    naziv VARCHAR(40) UNIQUE NOT NULL,
    opis VARCHAR(200)
);

CREATE TABLE stol (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    opis VARCHAR(80),
    mjesta INTEGER NOT NULL DEFAULT 4,
    status ENUM('slobodan', 'zauzet', 'rezerviran') DEFAULT 'slobodan',
    CHECK (mjesta BETWEEN 1 AND 20)
);

CREATE TABLE uloga (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    naziv VARCHAR(30) UNIQUE NOT NULL,
    opis VARCHAR(100)
);

CREATE TABLE djelatnik (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    oib CHAR(11) UNIQUE NOT NULL,
    ime VARCHAR(40) NOT NULL,
    prezime VARCHAR(40) NOT NULL,
    uloga_id INTEGER NOT NULL,
    aktivan BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (uloga_id) REFERENCES uloga(id)
);

CREATE TABLE artikl (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    naziv VARCHAR(40) UNIQUE NOT NULL,
    opis VARCHAR(80),
    cijena DECIMAL(8,2) NOT NULL CHECK (cijena > 0),
    dostupan BOOLEAN DEFAULT TRUE,
    kategorija_id INTEGER,
    FOREIGN KEY (kategorija_id) REFERENCES kategorija(id)
);

CREATE TABLE narudzba (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    zaprimio_id INTEGER NOT NULL,
    zaprimljena TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ispunjena TIMESTAMP NULL,
    status ENUM('aktivna', 'u_pripremi', 'gotova', 'naplacena'),
    stol_id INTEGER NOT NULL,
    FOREIGN KEY (zaprimio_id) REFERENCES djelatnik(id),
    FOREIGN KEY (stol_id) REFERENCES stol(id),
    INDEX idx_status (status),
    INDEX idx_stol (stol_id),
    INDEX idx_zaprimio_id (zaprimio_id),
    INDEX idx_zaprimljena (zaprimljena)
);

CREATE TABLE stavka_narudzbe (
    narudzba_id INTEGER NOT NULL,
    artikl_id INTEGER NOT NULL,
    kolicina INTEGER NOT NULL CHECK (kolicina > 0),
    vrijeme TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    status ENUM('naruceno', 'u_pripremi', 'gotovo') DEFAULT 'naruceno',
    napomena VARCHAR(200),
    FOREIGN KEY (narudzba_id) REFERENCES narudzba(id) ON DELETE CASCADE,
    FOREIGN KEY (artikl_id) REFERENCES artikl(id),
    PRIMARY KEY (artikl_id, narudzba_id),
    INDEX idx_status (status),
    INDEX idx_artikl_id (artikl_id)
);

CREATE TABLE rezervacija (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    mjesta INTEGER NOT NULL CHECK (mjesta > 0),
    od TIMESTAMP NOT NULL,
    do TIMESTAMP NOT NULL,
    kreirao_id INTEGER NOT NULL,
    kreirano TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    status ENUM('potvrdjena', 'na_cekanju', 'otkazana') DEFAULT 'na_cekanju',
    napomena VARCHAR(200) DEFAULT '',
    FOREIGN KEY (kreirao_id) REFERENCES djelatnik(id),
    CHECK (do > od)
);

CREATE TABLE stavka_rezervacije (
    rezervacija_id INTEGER NOT NULL,
    stol_id INTEGER NOT NULL,
    PRIMARY KEY (rezervacija_id, stol_id),
    FOREIGN KEY (rezervacija_id) REFERENCES rezervacija(id) ON DELETE CASCADE,
    FOREIGN KEY (stol_id) REFERENCES stol(id)
);

CREATE TABLE stavka_kategorije (
    kategorija_id INTEGER NOT NULL,
    artikl_id INTEGER NOT NULL,
    PRIMARY KEY (kategorija_id, artikl_id),
    FOREIGN KEY (kategorija_id) REFERENCES kategorija(id) ON DELETE CASCADE,
    FOREIGN KEY (artikl_id) REFERENCES artikl(id) ON DELETE CASCADE
);
