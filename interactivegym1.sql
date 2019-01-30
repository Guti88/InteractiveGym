-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 30 Sty 2019, 12:22
-- Wersja serwera: 10.1.36-MariaDB
-- Wersja PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `interactivegym`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `archiwum`
--

CREATE TABLE `archiwum` (
  `idOsoba` int(11) NOT NULL,
  `idTreningu` int(11) NOT NULL,
  `dataRozpoczecia` date NOT NULL,
  `dataZakonczenia` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `archiwum`
--

INSERT INTO `archiwum` (`idOsoba`, `idTreningu`, `dataRozpoczecia`, `dataZakonczenia`) VALUES
(5, 1, '2019-01-24', '2019-01-31');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `cwiczenie`
--

CREATE TABLE `cwiczenie` (
  `idCwiczenia` int(11) NOT NULL,
  `nazwa` text NOT NULL,
  `typ` enum('Plecy','K. piersiowa','Bicepsy','Tricepsy','Brzuch','Barki','Nogi','Kardio') NOT NULL,
  `sprzęt` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `cwiczenie`
--

INSERT INTO `cwiczenie` (`idCwiczenia`, `nazwa`, `typ`, `sprzęt`) VALUES
(1, 'Ławeczka wyciskanie sztangi', 'K. piersiowa', 'Ławeczka');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `dostep`
--

CREATE TABLE `dostep` (
  `idDostep` int(11) NOT NULL,
  `nazwa` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `dostep`
--

INSERT INTO `dostep` (`idDostep`, `nazwa`) VALUES
(1, 'Trener');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `osoba`
--

CREATE TABLE `osoba` (
  `idOsoba` int(11) NOT NULL,
  `PESEL` bigint(20) NOT NULL,
  `imie` varchar(25) NOT NULL,
  `nazwisko` text NOT NULL,
  `mail` text NOT NULL,
  `telefon` varchar(9) NOT NULL,
  `data_rejestracji` date NOT NULL,
  `DKU` date DEFAULT NULL COMMENT 'Data Końca Umowy',
  `waga` smallint(5) UNSIGNED DEFAULT NULL,
  `wzrost` smallint(5) UNSIGNED DEFAULT NULL,
  `rola_id` int(11) NOT NULL,
  `login` varchar(50) NOT NULL,
  `haslo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='	';

--
-- Zrzut danych tabeli `osoba`
--

INSERT INTO `osoba` (`idOsoba`, `PESEL`, `imie`, `nazwisko`, `mail`, `telefon`, `data_rejestracji`, `DKU`, `waga`, `wzrost`, `rola_id`, `login`, `haslo`) VALUES
(5, 94102956785, 'Lukasz', 'Barczykowski', 'Example@gmail.com', '454433234', '2019-01-24', '2019-01-31', 75, 175, 1, 'GUNJack', '123123'),
(6, 95051084736, 'Marta', 'Matuszak', 'Example2@gmail.com', '876546903', '0000-00-00', '2019-02-06', 50, 165, 2, 'Martta', '321321'),
(7, 88121385734, 'Katarzyna', 'Nowak', 'Jakis@gmail.com', '567098123', '2019-02-07', '2019-02-14', 123, 150, 2, 'FatGirl123', '123'),
(8, 88010145813, 'Janusz', 'Tracz', 'JanNusz@gmail.com', '543890160', '2019-01-24', '2019-02-06', 150, 200, 1, 'Jannn', 'taknie'),
(9, 70030549230, 'Bartłomiej', 'Zuzek', 'ZuzBar@gmail.com', '784267099', '2019-02-07', '2019-02-14', 80, 185, 2, 'Barzzuz', 'qwe');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `progress`
--

CREATE TABLE `progress` (
  `idProgress` int(11) NOT NULL,
  `nazwa` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `progress`
--

INSERT INTO `progress` (`idProgress`, `nazwa`) VALUES
(1, 'Klatka');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rola`
--

CREATE TABLE `rola` (
  `idRola` int(11) NOT NULL,
  `Nazwa` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `rola`
--

INSERT INTO `rola` (`idRola`, `Nazwa`) VALUES
(1, 'Trener'),
(2, 'Użytkownik ');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rola-dostep`
--

CREATE TABLE `rola-dostep` (
  `idRola` int(11) NOT NULL,
  `idDostep` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `rola-dostep`
--

INSERT INTO `rola-dostep` (`idRola`, `idDostep`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `trening`
--

CREATE TABLE `trening` (
  `idTreningu` int(11) NOT NULL,
  `nazwa` varchar(15) NOT NULL,
  `typ` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `trening`
--

INSERT INTO `trening` (`idTreningu`, `nazwa`, `typ`) VALUES
(1, 'Fat-burn', 'Cardio'),
(2, 'Trening góra', 'Work-out '),
(3, 'Bieg', 'Kondycja');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `trening-cwiczenia`
--

CREATE TABLE `trening-cwiczenia` (
  `idTreningu` int(11) NOT NULL,
  `idCwiczenia` int(11) NOT NULL,
  `serie` smallint(6) NOT NULL,
  `powtorzenia` smallint(6) NOT NULL,
  `przerwa` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `trening-cwiczenia`
--

INSERT INTO `trening-cwiczenia` (`idTreningu`, `idCwiczenia`, `serie`, `powtorzenia`, `przerwa`) VALUES
(1, 1, 4, 12, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownik-progress`
--

CREATE TABLE `uzytkownik-progress` (
  `idUzytkownika` int(11) NOT NULL,
  `idProgressu` int(11) NOT NULL,
  `wymiar` smallint(6) NOT NULL DEFAULT '0',
  `max` smallint(6) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `uzytkownik-progress`
--

INSERT INTO `uzytkownik-progress` (`idUzytkownika`, `idProgressu`, `wymiar`, `max`) VALUES
(5, 1, 98, 112);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `archiwum`
--
ALTER TABLE `archiwum`
  ADD KEY `idOsoba` (`idOsoba`),
  ADD KEY `idTreningu` (`idTreningu`);

--
-- Indeksy dla tabeli `cwiczenie`
--
ALTER TABLE `cwiczenie`
  ADD PRIMARY KEY (`idCwiczenia`);

--
-- Indeksy dla tabeli `dostep`
--
ALTER TABLE `dostep`
  ADD PRIMARY KEY (`idDostep`);

--
-- Indeksy dla tabeli `osoba`
--
ALTER TABLE `osoba`
  ADD PRIMARY KEY (`idOsoba`),
  ADD UNIQUE KEY `Tel_UNIQUE` (`telefon`),
  ADD UNIQUE KEY `PESEL_UNIQUE` (`PESEL`),
  ADD UNIQUE KEY `login_UNIQUE` (`login`),
  ADD UNIQUE KEY `haslo_UNIQUE` (`haslo`),
  ADD KEY `rola_id` (`rola_id`);

--
-- Indeksy dla tabeli `progress`
--
ALTER TABLE `progress`
  ADD PRIMARY KEY (`idProgress`);

--
-- Indeksy dla tabeli `rola`
--
ALTER TABLE `rola`
  ADD PRIMARY KEY (`idRola`);

--
-- Indeksy dla tabeli `rola-dostep`
--
ALTER TABLE `rola-dostep`
  ADD KEY `idDostep_idx` (`idDostep`),
  ADD KEY `idRola` (`idRola`);

--
-- Indeksy dla tabeli `trening`
--
ALTER TABLE `trening`
  ADD PRIMARY KEY (`idTreningu`),
  ADD UNIQUE KEY `Nazwa_UNIQUE` (`nazwa`);

--
-- Indeksy dla tabeli `trening-cwiczenia`
--
ALTER TABLE `trening-cwiczenia`
  ADD KEY `ID_Treningu_idx` (`idTreningu`),
  ADD KEY `ID_cwiczenia_idx` (`idCwiczenia`);

--
-- Indeksy dla tabeli `uzytkownik-progress`
--
ALTER TABLE `uzytkownik-progress`
  ADD KEY `idProgress_idx` (`idProgressu`),
  ADD KEY `idUzytkownika` (`idUzytkownika`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `cwiczenie`
--
ALTER TABLE `cwiczenie`
  MODIFY `idCwiczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `dostep`
--
ALTER TABLE `dostep`
  MODIFY `idDostep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `osoba`
--
ALTER TABLE `osoba`
  MODIFY `idOsoba` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT dla tabeli `progress`
--
ALTER TABLE `progress`
  MODIFY `idProgress` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `rola`
--
ALTER TABLE `rola`
  MODIFY `idRola` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `trening`
--
ALTER TABLE `trening`
  MODIFY `idTreningu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `archiwum`
--
ALTER TABLE `archiwum`
  ADD CONSTRAINT `archiwum_ibfk_1` FOREIGN KEY (`idOsoba`) REFERENCES `osoba` (`idOsoba`),
  ADD CONSTRAINT `archiwum_ibfk_2` FOREIGN KEY (`idTreningu`) REFERENCES `trening` (`idTreningu`);

--
-- Ograniczenia dla tabeli `osoba`
--
ALTER TABLE `osoba`
  ADD CONSTRAINT `osoba_ibfk_1` FOREIGN KEY (`rola_id`) REFERENCES `rola` (`idRola`);

--
-- Ograniczenia dla tabeli `rola-dostep`
--
ALTER TABLE `rola-dostep`
  ADD CONSTRAINT `idDostep` FOREIGN KEY (`idDostep`) REFERENCES `dostep` (`idDostep`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `idRola` FOREIGN KEY (`idRola`) REFERENCES `rola` (`idRola`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ograniczenia dla tabeli `trening-cwiczenia`
--
ALTER TABLE `trening-cwiczenia`
  ADD CONSTRAINT `ID_cwiczenia` FOREIGN KEY (`idCwiczenia`) REFERENCES `cwiczenie` (`idCwiczenia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `ID_treningu` FOREIGN KEY (`idTreningu`) REFERENCES `trening` (`idTreningu`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ograniczenia dla tabeli `uzytkownik-progress`
--
ALTER TABLE `uzytkownik-progress`
  ADD CONSTRAINT `idProgress` FOREIGN KEY (`idProgressu`) REFERENCES `progress` (`idProgress`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `idUzytkownika` FOREIGN KEY (`idUzytkownika`) REFERENCES `osoba` (`idOsoba`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
