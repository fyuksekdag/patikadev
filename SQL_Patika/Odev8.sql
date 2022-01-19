-- test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
	id SERIAL PRIMARY KEY,
	name VARCHAR(60),
	email VARCHAR(100),
	birthday DATE
);

-- Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

insert into employee (name, email, birthday) values ('Jennie', 'jsymmons0@berkeley.edu', '1982-01-05');
insert into employee (name, email, birthday) values ('Saree', 'sajean1@gov.uk', '1961-07-21');
insert into employee (name, email, birthday) values ('Ada', 'aleads2@edublogs.org', '1960-04-18');
insert into employee (name, email, birthday) values ('Kyla', 'kkyd3@vinaora.com', '1921-03-12');
insert into employee (name, email, birthday) values ('Gae', 'gcampbell4@ox.ac.uk', '1948-09-19');
insert into employee (name, email, birthday) values ('Fifine', 'foxnam5@stanford.edu', '1999-01-21');
insert into employee (name, email, birthday) values ('Ario', null, '1945-01-29');
insert into employee (name, email, birthday) values ('Franciska', 'ftrusslove7@spiegel.de', '1944-08-30');
insert into employee (name, email, birthday) values ('Sherwynd', 'sconaghan8@prnewswire.com', '1945-11-24');
insert into employee (name, email, birthday) values ('Florry', 'fandrivot9@jimdo.com', '1950-08-14');
insert into employee (name, email, birthday) values ('Shermie', 'sspavinsa@hao123.com', '1913-10-18');
insert into employee (name, email, birthday) values ('Joli', 'jstaveb@intel.com', '1908-07-03');
insert into employee (name, email, birthday) values ('Natalie', null, '1998-08-20');
insert into employee (name, email, birthday) values ('Loren', 'lbinnesd@abc.net.au', '1950-12-15');
insert into employee (name, email, birthday) values ('Vida', 'vatlaye@shutterfly.com', '1989-08-23');
insert into employee (name, email, birthday) values ('Halsey', 'hjoubertf@altervista.org', '1999-03-01');
insert into employee (name, email, birthday) values ('Nonie', 'nklyng@friendfeed.com', '1981-07-10');
insert into employee (name, email, birthday) values ('Rorie', 'rmcgloughlinh@jalbum.net', '1915-06-20');
insert into employee (name, email, birthday) values ('Clarita', 'csemmencei@goo.gl', '1947-10-06');
insert into employee (name, email, birthday) values ('Mikol', 'mjewissj@domainmarket.com', '1930-07-21');
insert into employee (name, email, birthday) values ('Bentlee', 'bdearnk@engadget.com', '1958-03-31');
insert into employee (name, email, birthday) values ('Elysha', 'emilal@netlog.com', '1962-05-02');
insert into employee (name, email, birthday) values ('Shay', 'syeardleym@google.com.au', '1945-10-06');
insert into employee (name, email, birthday) values ('Dorian', 'dbuttersn@who.int', '1902-04-05');
insert into employee (name, email, birthday) values ('Derron', 'ddobkino@uol.com.br', '1953-01-14');
insert into employee (name, email, birthday) values ('Nancy', 'nsaketp@bandcamp.com', '1996-04-16');
insert into employee (name, email, birthday) values ('Goran', 'gbowkettq@altervista.org', '1952-02-11');
insert into employee (name, email, birthday) values ('Caritta', 'ctarrierr@nationalgeographic.com', '1901-08-11');
insert into employee (name, email, birthday) values ('Zonda', 'zlevenes@jigsy.com', '1932-09-24');
insert into employee (name, email, birthday) values ('Eziechiele', 'ewishamt@auda.org.au', '1924-07-08');
insert into employee (name, email, birthday) values ('Holly-anne', 'hrickardsu@lycos.com', '1942-10-31');
insert into employee (name, email, birthday) values ('Daron', 'dcorryerv@spotify.com', '1948-07-27');
insert into employee (name, email, birthday) values ('Maisie', 'mprielw@usda.gov', '1983-11-13');
insert into employee (name, email, birthday) values ('Temp', 'tpeealessx@behance.net', '1924-04-20');
insert into employee (name, email, birthday) values ('Adelheid', 'acrallany@drupal.org', '1926-06-04');
insert into employee (name, email, birthday) values ('Quintana', 'qmartinotz@i2i.jp', '1999-09-23');
insert into employee (name, email, birthday) values ('Cleavland', 'ccarding10@hugedomains.com', '1954-05-22');
insert into employee (name, email, birthday) values ('Neile', 'nkesteven11@digg.com', '1993-08-23');
insert into employee (name, email, birthday) values ('Teirtza', 'tsalisbury12@sciencedirect.com', '1931-01-14');
insert into employee (name, email, birthday) values ('Appolonia', 'adrury13@last.fm', '1940-06-12');
insert into employee (name, email, birthday) values ('Alanna', 'aladyman14@psu.edu', '1953-12-02');
insert into employee (name, email, birthday) values ('Rosabelle', 'rskpsey15@slate.com', '1921-01-21');
insert into employee (name, email, birthday) values ('Cesaro', 'cfaas16@gizmodo.com', '1952-08-17');
insert into employee (name, email, birthday) values ('Lusa', 'ljanek17@salon.com', '1959-06-26');
insert into employee (name, email, birthday) values ('Norry', 'ndarree18@paypal.com', '1987-02-06');
insert into employee (name, email, birthday) values ('Brunhilde', 'binkles19@illinois.edu', '1998-04-09');
insert into employee (name, email, birthday) values ('Florrie', 'fannice1a@wix.com', '1937-10-03');
insert into employee (name, email, birthday) values ('Joe', 'jwestrey1b@gnu.org', '1994-04-01');
insert into employee (name, email, birthday) values ('Rodrique', 'rprobet1c@jiathis.com', '1989-01-19');
insert into employee (name, email, birthday) values ('Xylina', 'xmacilurick1d@mediafire.com', '1926-03-25');

-- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım

UPDATE employee SET name = 'Stux' WHERE id = 5;
UPDATE employee SET email = 'sherwynzero@da.com' WHERE name = 'Sherwynd';
UPDATE employee SET birthday = '1988-04-17' WHERE email = 'kkyd3@vinaora.com';
UPDATE employee SET name = 'Foffana' WHERE birthday = '1999-01-21';
UPDATE employee SET email = 'halsey@halsey.com' WHERE name = 'Halsey';

-- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

DELETE employee WHERE name = 'Nonie';
DELETE employee WHERE email = 'csemmencei@goo.gl';
DELETE employee WHERE birthday = '1958-03-31';
DELETE employee WHERE id = 37;
DELETE employee WHERE name = 'Neile';
