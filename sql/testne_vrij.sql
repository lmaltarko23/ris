
INSERT INTO stol (id, opis, mjesta, status) VALUES
	 (1, 'Šank',6,'slobodan'),
	 (2, 'Vanjski stol 1',4,'slobodan'),
	 (3, 'Vanjski stol 2',4,'slobodan'),
	 (4, 'Vanjski stol 3',5,'slobodan'),
	 (5, 'Vanjski stol 4',2,'slobodan'),
	 (6, 'Stol uz stakleni zid 1',3,'slobodan'),
	 (7, 'Stol uz stakleni zid 2',4,'rezerviran'),
	 (8, 'Stol uz stakleni zid 3',3,'slobodan'),
	 (9, 'Stol uz stakleni zid 4',2,'slobodan'),
	 (10, 'Stol uz stakleni zid 5',2,'slobodan'),
	 (11, 'Veliki stol',10,'slobodan'),
	 (12, 'Kauč 1',6,'slobodan'),
	 (13, 'Kauč 2',6,'slobodan'),
	 (14, 'Mali stol uz kauče 1',2,'slobodan'),
	 (15, 'Mali stol uz kauče 2',2,'zauzet'),
	 (16, 'Stol na balkonu 1',4,'slobodan'),
	 (17, 'Stol na balkonu 2',3,'slobodan'),
	 (18, 'Stol na balkonu 3',4,'slobodan'),
	 (19, 'Stol na balkonu 4',3,'slobodan'),
	 (20, 'Stol na balkonu 5',4,'slobodan'),
	 (21, 'Stol na balkonu 6',3,'slobodan'),
	 (22, 'Ljuljačka na balkonu',5,'slobodan'),
	 (23, 'Stol uz prozor',4,'slobodan'),
	 (24, 'Stol u sredini',6,'zauzet'),
	 (25, 'Kutni stol',2,'slobodan'),
	 (26, 'Veliki obiteljski stol',8,'rezerviran'),
	 (27, 'Šank stol',3,'slobodan');

INSERT INTO uloga (id, naziv, opis) VALUES
(1, 'Konobar', 'Zaprima narudžbe'),
(2, 'Kuhar', 'Priprema jela'),
(3, 'Glavni kuhar', 'Koordinira radom kuhinje'),
(4, 'Voditelj restorana', 'Upravlja restoranom'),
(5, 'Servir', 'Nosi narudžbe i odgovara na upite klijenata');


INSERT INTO djelatnik (id, oib, ime, prezime, uloga_id, aktivan) VALUES
(1, '12345678901', 'Ivo', 'Ivić', 1, TRUE),
(2, '12345678902', 'Ana', 'Anić', 1, TRUE),
(3, '12345678903', 'Marko', 'Markić', 2, TRUE),
(4, '12345678904', 'Ivana', 'Ivanović', 3, TRUE),
(5, '12345678905', 'Pero', 'Perić', 5, TRUE);

INSERT INTO kategorija (id, naziv, opis) VALUES
(1, 'Pića', 'Pića koja ne spadaju u ostale kategorije'),
(2, 'Kava', 'Kava'),
(3, 'Gazirana pića', 'Slatka bezalkoholna gazirana pića'),
(4, 'Voda', 'Gazirana i negazirana voda'),
(5, 'Vino', 'Alkoholno piće proizvedeno od grožđa'),
(6, 'Žestica', 'Alkoholna pića visoke gradacije'),
(7, 'Sok', 'Negazirana slatka pića'),
(8, 'Čaj', 'Topli napitak napravljen na licu mjesta'),
(9, 'Predjelo', 'Predjela koja ne spadaju u ostale kategorije'),
(10, 'Juha', 'Juhe'),
(15, 'Prilozi', 'Prilozi'),
(16, 'Prilozi (krumpir)', 'Prilozi na bazi krumpira'),
(17, 'Prilog (tjestenina)', 'Prilozi na bazi tjestenine'),
(18, 'Salata', 'Salate'), 
(20, 'Glavno jelo', 'Glavna jela'),
(21, 'Pašta', 'Glavno jelo na bazi tjestenine'),
(22, 'Pizza', 'Pizza'),
(23, 'Burger', 'Veći sendvič'),
(25, 'Desert', 'Slastice i kolači koji ne spadaju u ostale kategorije'),
(26, 'Torta', 'Torte'),
(27, 'Kolači', 'Kolači'),
(28, 'Sladoled', 'Sladoled');

INSERT INTO artikl (id, naziv, opis, cijena, dostupan, kategorija_id) VALUES
(1, 'Coca-Cola', 'Gazirano piće', 3.00, TRUE, 1),
(2, 'Mineralna voda', 'Gazirana, 1 l', 2.50, TRUE, 1),
(3, 'Pileća juha', 'Juha od piletine', 4.00, TRUE, 2),
(4, 'Goveđi gulaš', 'Gulaš s krumpirom', 9.50, TRUE, 3),
(5, 'Pomfrit', 'Prženi krumpirići', 3.50, TRUE, 4),
(6, 'Palačinke', 'Palačinke s marmeladom', 4.50, TRUE, 5);

INSERT INTO stavka_kategorije (artikl_id, kategorija_id) VALUES
(1, 3),
(2, 4),
(3, 10),
(4, 10),
(5, 16),
(6, 25);

INSERT INTO narudzba (zaprimio_id, status, stol_id) VALUES
(1, 'aktivna', 1),
(2, 'u_pripremi', 2),
(1, 'gotova', 3),
(2, 'naplacena', 2),
(1, 'aktivna', 5);

INSERT INTO stavka_narudzbe (narudzba_id, artikl_id, kolicina, status, napomena) VALUES
(1, 1, 2, 'naruceno', ''),
(1, 3, 1, 'u_pripremi', 'Bez soli'),
(2, 4, 1, 'u_pripremi', ''),
(3, 5, 2, 'gotovo', ''),
(4, 6, 1, 'gotovo', '');

INSERT INTO rezervacija (mjesta, od, do, kreirao_id, status, napomena) VALUES
(4, '2026-01-20 18:00:00', '2026-01-20 20:00:00', 1, 'potvrdjena', ''),
(2, '2026-01-21 19:00:00', '2026-01-21 21:00:00', 2, 'na_cekanju', ''),
(6, '2026-01-22 17:00:00', '2026-01-22 19:00:00', 1, 'potvrdjena', ''),
(8, '2026-01-23 18:00:00', '2026-01-23 22:00:00', 5, 'potvrdjena', ''),
(3, '2026-01-24 12:00:00', '2026-01-24 14:00:00', 2, 'otkazana', '');

INSERT INTO stavka_rezervacije (rezervacija_id, stol_id) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 4),
(5, 5);
