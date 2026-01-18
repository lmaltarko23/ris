-- Upit koji dohvaća sve artikle bez evidentirane kategorije
SELECT a.naziv, a.cijena
	FROM artikl a
	WHERE a.kategorija_id IS NULL;


-- Upit koji dohvaća sve artikle svih narudžbi i računa međuzbroj
SELECT 
	n.id AS 'Broj narudžbe', 
	a.naziv AS 'Artikl', 
	s.kolicina AS 'Količina',
	(a.cijena * s.kolicina) AS 'Međuzbroj'
	FROM narudzba n 
	LEFT JOIN stavka_narudzbe s ON s.narudzba_id  = n.id
	LEFT JOIN artikl a ON a.id = s.artikl_id
	ORDER BY n.id;

-- Upit koji ispisuje sve narudžbe s ukupnim iznosom i drugim relevntnim podatcima
SELECT 
	n.id AS 'Broj narudžbe',
	n.zaprimljena AS 'Datum,',
	n.status AS 'Status',
	SUM(a.cijena * s.kolicina) AS 'Međuzbroj'
	FROM narudzba n
	LEFT JOIN stavka_narudzbe s ON s.narudzba_id = n.id
	LEFT JOIN artikl a ON a.id = s.artikl_id
	GROUP BY n.id, n.zaprimljena, n.status
	ORDER BY n.id;

-- Upit koji ispisuje sve rezervacije: Koji stol i u koje vrijeme (od-do)
SELECT 
	s.opis AS 'Stol',
	r.od AS 'Rezervirano od', 
	r.do AS 'Rezervirano do'
	FROM stavka_rezervacije st
	LEFT JOIN rezervacija r ON st.rezervacija_id = r.id
	LEFT JOIN stol s ON st.stol_id = s.id
	ORDER BY s.opis;

-- Upit koji vraća naziv artikla, prebrojava prodanost i računa ukupni prihod po artiklu
SELECT 
	a.naziv AS 'Artikl',
	COALESCE(SUM(st.kolicina), 0) AS 'Jedinica prodano',
	CONCAT('x') AS 'x',
	CONCAT(a.cijena, ' €') AS 'Jedinična cijena',
	CONCAT('=') AS '=',
	CONCAT(COALESCE (a.cijena * SUM(st.kolicina), 0), ' €') AS 'Ukupno'
	FROM artikl a
	LEFT JOIN stavka_narudzbe st ON a.id = st.artikl_id
	GROUP BY a.naziv
	ORDER BY 2 DESC;

