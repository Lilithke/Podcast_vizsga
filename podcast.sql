-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Ápr 27. 03:33
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `podcast`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `fogalas`
--

CREATE TABLE `fogalas` (
  `foglalasid` bigint(20) UNSIGNED NOT NULL,
  `felhasznaloid` bigint(20) UNSIGNED NOT NULL,
  `foglalaskezdete` datetime NOT NULL,
  `foglalasvege` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `megrendelo`
--

CREATE TABLE `megrendelo` (
  `felhasznaloid` bigint(20) UNSIGNED NOT NULL,
  `felhsznalonev` varchar(12) DEFAULT NULL,
  `jelszo` int(6) DEFAULT NULL,
  `nev` varchar(13) DEFAULT NULL,
  `email` varchar(22) DEFAULT NULL,
  `lakcim_irsz` int(4) DEFAULT NULL,
  `lakcim_telepules` varchar(10) DEFAULT NULL,
  `lakcim_cim` varchar(24) DEFAULT NULL,
  `telefonszam` varchar(20) DEFAULT NULL,
  `szamlazasi_adatatok` enum('true','false') DEFAULT 'true',
  `szigsz` varchar(8) DEFAULT NULL,
  `szuletesi_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `megrendelo`
--

INSERT INTO `megrendelo` (`felhasznaloid`, `felhsznalonev`, `jelszo`, `nev`, `email`, `lakcim_irsz`, `lakcim_telepules`, `lakcim_cim`, `telefonszam`, `szamlazasi_adatatok`, `szigsz`, `szuletesi_datum`) VALUES
(1, 'kismiki', 123654, 'Kiss Miklós', 'kissmiklos@gmail.com', 7630, 'Pécs', 'Diósi út 2.', '3670263592', 'false', '023648PU', '2005-12-02'),
(2, 'lustapisti', 894561, 'Lusta Pista', 'lustapisti@gmail.com', 1048, ' Budapest', 'Galopp utca 8.', '3620956320', 'false', '567894LO', '1999-05-03'),
(3, 'boldogmarcsi', 538975, 'Boldog Mária', 'boldogmaria@gmail.com', 2143, ' Kistarcsa', 'Gaz utca 45.', '3630635489', 'false', '652231GH', '2000-07-09'),
(4, 'feszekancsa', 369741, 'Fészek Anna', 'feszekanna@gmail.com', 1131, ' Budapest', 'Madarász Viktor utca 26.', '3670592825', 'true', '658927CH', '1988-02-16'),
(5, 'polgijenci', 369755, 'Polgár Jenő', 'polgarjeno@gmail.com', 8500, ' Pápa', 'Kis Miklós utca 66.', '3630269789', 'false', '659362HJ', '1978-05-30'),
(6, 'gyongyszem', 236569, 'Szép Mária', 'szepmaria@gmail.com', 7400, ' Kaposvár', 'Zavaros völgy utca 99.', '3651269785', 'true', '369542LK', '1993-08-23'),
(7, 'haszferi', 268942, 'Hasznos Feri', 'hasznosferi@gmail.com', 9400, ' Sopron', 'Folyó víz utca 87.', '3620569315', 'false', '365321KU', '1984-10-14'),
(8, 'garasos', 154896, 'Garas Géza', 'garasgeza@gmail.com', 1032, ' Budapest', 'Kiscelli utca 2.', '3620489633', 'false', '422359SD', '1974-11-06'),
(9, 'felenkibi', 478992, 'Félénk Ibolya', 'felenkibolya@gmail.com', 2146, ' Mogyoród', 'Fazekas István út 56.', '3670452256', 'true', '695324XC', '1999-09-25'),
(10, 'bajosbarbi', 536978, 'Bájos Barbara', 'bajosbarbara@gmail.com', 2600, ' Vác', 'Nagy Imre utca 23.', '36305666556', 'false', '237899VB', '1985-08-01');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szamlatetelek`
--

CREATE TABLE `szamlatetelek` (
  `szamlaid` bigint(20) UNSIGNED NOT NULL,
  `szolgaltatasid` bigint(20) UNSIGNED NOT NULL,
  `mennyiseg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szamlazasiadatok`
--

CREATE TABLE `szamlazasiadatok` (
  `szamlaid` bigint(20) UNSIGNED NOT NULL,
  `felhasznaloid` bigint(20) UNSIGNED NOT NULL,
  `szamlaazonosito` varchar(20) NOT NULL COMMENT 'Minden kiállított számlának egyedi azonosítóval kell rendelkeznie',
  `bankszamlaszam` varchar(20) DEFAULT NULL COMMENT 'csak átutalásos számlánál kell emegadni',
  `szamlazasiirsz` varchar(8) NOT NULL COMMENT 'Lehet más országbeli?',
  `szamlatelepules` varchar(30) NOT NULL,
  `szamlacime` varchar(30) NOT NULL,
  `teljesitesvege` date NOT NULL COMMENT 'a szolgaltatas utolso napja',
  `kiallitva` date NOT NULL,
  `teljesitesdatum` date NOT NULL COMMENT 'általában 14 nap',
  `teljesitve` enum('true','false') NOT NULL DEFAULT 'false'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szolgaltatasok`
--

CREATE TABLE `szolgaltatasok` (
  `szolgaltatasid` bigint(20) NOT NULL,
  `szolgaltatasmegnevezes` varchar(50) NOT NULL,
  `csomagid` bigint(20) DEFAULT NULL,
  `szolgaltataskezdete` datetime NOT NULL,
  `szolgaltatasvege` datetime NOT NULL,
  `ar` decimal(20,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `szolgaltatasok`
--

INSERT INTO `szolgaltatasok` (`szolgaltatasid`, `szolgaltatasmegnevezes`, `csomagid`, `szolgaltataskezdete`, `szolgaltatasvege`, `ar`) VALUES
(1, 'catering', NULL, '2024-03-11 19:01:04', '2024-03-11 19:01:04', 0),
(2, 'technikus', NULL, '2024-03-11 19:01:04', '2024-03-11 19:01:04', 0),
(3, 'utomunka', NULL, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(4, 'felhoalaputarhely', NULL, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(5, 'grafikatervezes', 7, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(6, 'livestream', NULL, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(7, 'Basic csomag', NULL, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `felhasznaloid` bigint(20) UNSIGNED NOT NULL,
  `nev` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `jelszo` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL DEFAULT 'user',
  `telefonszam` varchar(255) NOT NULL,
  `szemelyi_szam` varchar(255) NOT NULL,
  `szuletesi_datum` date NOT NULL,
  `ceg` tinyint(1) NOT NULL DEFAULT 0,
  `cegnev` varchar(255) DEFAULT NULL,
  `ceg_tipus` varchar(255) DEFAULT NULL,
  `ado_szam` varchar(255) DEFAULT NULL,
  `bankszamlaszam` varchar(255) DEFAULT NULL,
  `orszag` varchar(255) NOT NULL,
  `iranyitoszam` varchar(255) NOT NULL,
  `varos` varchar(255) NOT NULL,
  `utca` varchar(255) NOT NULL,
  `utca_jellege` varchar(255) NOT NULL,
  `hazszam` varchar(255) NOT NULL,
  `epulet` varchar(255) DEFAULT NULL,
  `lepcsohaz` varchar(255) DEFAULT NULL,
  `emelet` varchar(255) DEFAULT NULL,
  `ajto` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`felhasznaloid`, `nev`, `email`, `jelszo`, `role`, `telefonszam`, `szemelyi_szam`, `szuletesi_datum`, `ceg`, `cegnev`, `ceg_tipus`, `ado_szam`, `bankszamlaszam`, `orszag`, `iranyitoszam`, `varos`, `utca`, `utca_jellege`, `hazszam`, `epulet`, `lepcsohaz`, `emelet`, `ajto`, `created_at`, `updated_at`) VALUES
(1, 'Michele Nitzsche', 'beatty.zachary@example.org', '$2y$12$viPpYpQ90.QoSYkZreRFeuoBT3aPgysNqxQ/CEe6KD0uZ6psWhJ8u', 'user', '+18385764432', '4kG43ssv', '1995-03-17', 1, 'Sanford-Pfannerstill', 'Kft', '55970101', 'HU49034428761387447841550681', 'Magyarország', '87871', 'New Henriette', 'Cordia Flats', 'út', '547', 'c', '4', '2', '8', '2024-04-24 19:06:39', '2024-04-24 19:06:39'),
(2, 'Dr. Josiane Marci', 'horacio.hegmann@example.com', '$2y$12$ii3v3Hunh8tbNjn8GvDVyucgODPfPDEEhL2FyRNvJVwcuvJ2C7QOS', 'user', '1-385-908-6357', 'Io1w78xX', '1987-05-24', 1, 'Adácska', 'Kft', '84996018', 'HU40915189353124046689998381', 'Magyarország', '22147-8474', 'Port Ansel', 'Magnolia Extension', 'tér', '55460', 's', '2', '5', '4', '2024-04-24 19:06:39', '2024-04-24 19:06:39'),
(3, 'Dawn Franecki Jr.', 'zaria89@example.com', '$2y$12$RcfwWYhz2vIQiRYYK4FL1.iFjFcf3GigxPSijVZxWocYcGIC39A4y', 'user', '848.887.3114', 'p0SQj8bx', '2005-06-25', 1, 'Altenwerth, Leffler and Smith', 'Kft', '53935883', 'HU68472931934624129682995132', 'Magyarország', '15555', 'Port Dakota', 'Dewayne Inlet', 'út', '191', 'i', '9', '8', '6', '2024-04-24 19:06:40', '2024-04-24 19:06:40'),
(4, 'Kiss Lotti', 'kisspista7@example.com', '$2y$12$lmmMUVrOUDUqvdqBIhP33eX3CeD3b2h7vIYWmp.XpKN0p/bzujhuq', 'user', '903-576-1776', '85406473', '1974-09-28', 1, 'haho', 'Bt', '04693248', 'HU76308795516645198303168102', 'Magyarország', '32766-1111111', 'vbnvbn', 'Dániel', 'út', '1125', 'y', '7', '7', '4', '2024-04-25 21:01:23', '2024-04-25 21:01:23'),
(5, 'Tudva Mónika', 'dudvamonika@gmail.com', '$2y$12$DusVrT.Nb0ercijSjyQNeOejbnHxXGN/SBz7Bw5tID2HXg45T3Wie', 'user', '903-576-1776', '85406473', '1974-09-28', 1, 'Robika', 'Bt', '04693248', 'HU76308795516645198303168102', 'Magyarország', '32766-0845', 'Budapest', 'Dániel', 'út', '1125', 'y', '7', '7', '4', '2024-04-25 23:01:22', '2024-04-25 23:01:22');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `fogalas`
--
ALTER TABLE `fogalas`
  ADD PRIMARY KEY (`foglalasid`);

--
-- A tábla indexei `megrendelo`
--
ALTER TABLE `megrendelo`
  ADD PRIMARY KEY (`felhasznaloid`);

--
-- A tábla indexei `szamlazasiadatok`
--
ALTER TABLE `szamlazasiadatok`
  ADD PRIMARY KEY (`szamlaid`);

--
-- A tábla indexei `szolgaltatasok`
--
ALTER TABLE `szolgaltatasok`
  ADD PRIMARY KEY (`szolgaltatasid`),
  ADD KEY `fk_szolgaltatas_csomag` (`csomagid`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`felhasznaloid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `fogalas`
--
ALTER TABLE `fogalas`
  MODIFY `foglalasid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `megrendelo`
--
ALTER TABLE `megrendelo`
  MODIFY `felhasznaloid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `szamlazasiadatok`
--
ALTER TABLE `szamlazasiadatok`
  MODIFY `szamlaid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `szolgaltatasok`
--
ALTER TABLE `szolgaltatasok`
  MODIFY `szolgaltatasid` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `felhasznaloid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `szolgaltatasok`
--
ALTER TABLE `szolgaltatasok`
  ADD CONSTRAINT `fk_szolgaltatas_csomag` FOREIGN KEY (`csomagid`) REFERENCES `szolgaltatasok` (`szolgaltatasid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
