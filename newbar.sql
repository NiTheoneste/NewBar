-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2024 at 02:58 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `newbar`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `ID` varchar(30) NOT NULL,
  `Nom` varchar(30) DEFAULT NULL,
  `Prenom` varchar(30) DEFAULT NULL,
  `Phone` varchar(30) DEFAULT NULL,
  `Adresse` varchar(30) DEFAULT NULL,
  `Nationalite` varchar(30) DEFAULT NULL,
  `Sexe` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ID`, `Nom`, `Prenom`, `Phone`, `Adresse`, `Nationalite`, `Sexe`) VALUES
('0001', 'Kabura', 'Fabrice George', '55483', 'Gihosha', 'RD Congo', ''),
('005', 'Nizerimana', 'Théoneste', '5241698', 'Rutana', 'Rwanda', 'Homme');

-- --------------------------------------------------------

--
-- Table structure for table `produits`
--

CREATE TABLE `produits` (
  `ID` varchar(50) NOT NULL,
  `Nom` varchar(50) DEFAULT NULL,
  `Quantite` int(11) DEFAULT NULL,
  `PrixUnitaire` double DEFAULT NULL,
  `Volume` float DEFAULT NULL,
  `DateExpiration` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produits`
--

INSERT INTO `produits` (`ID`, `Nom`, `Quantite`, `PrixUnitaire`, `Volume`, `DateExpiration`) VALUES
('PRO-001/24', 'AMSTEL', 30, 3000, 370, '2026-06-10 00:38:43'),
('PRO-002/24', 'PRIMUS', 0, 2200, 375, '2024-04-19 13:05:17'),
('PRO-003/24', 'BECHOU', 70, 2600, 330, '2024-04-19 16:41:38'),
('PRO-004/24', 'BAJOU', 32, 1700, 310, '2024-04-19 16:42:12');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `Matricule` varchar(50) NOT NULL,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Phone` varchar(30) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Sexe` varchar(20) DEFAULT NULL,
  `Profil` varchar(30) DEFAULT NULL,
  `Username` varchar(30) DEFAULT NULL,
  `Password` varchar(30) DEFAULT NULL,
  `Adresse` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utilisateurs`
--

INSERT INTO `utilisateurs` (`Matricule`, `Nom`, `Prenom`, `Age`, `Phone`, `Email`, `Sexe`, `Profil`, `Username`, `Password`, `Adresse`) VALUES
('UT-001/24', 'Nizerimana', 'Théoneste', 20, '+257 62596292', 'nithe@biu.bi', 'Homme', 'Gérant', 'NiThe', 'NiThe153', 'Gihosha'),
('UT-002/24', 'Tuyishemeze', 'Claudine', 18, '+257 69370911', 'tuclau@biu.bi', '', 'Réceptioniste', 'TuClau', 'TuClau2024', 'Rohero'),
('UT-003/24', 'KIMANA', 'Bernice', 15, '+257 69854127', 'berki@biu.bi', '', 'Serveur', 'Wapi', 'Wapi153', 'Kigobe');

-- --------------------------------------------------------

--
-- Table structure for table `ventes`
--

CREATE TABLE `ventes` (
  `ID` int(11) NOT NULL,
  `Client` varchar(30) DEFAULT NULL,
  `Produit` varchar(30) DEFAULT NULL,
  `Quantite` int(11) DEFAULT NULL,
  `PrixUnitaire` double DEFAULT NULL,
  `PrixTotal` double DEFAULT NULL,
  `DateOperation` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ventes`
--

INSERT INTO `ventes` (`ID`, `Client`, `Produit`, `Quantite`, `PrixUnitaire`, `PrixTotal`, `DateOperation`) VALUES
(1, '005', 'PRO-001/24', 15, 3000, 45000, '2024-04-19 15:53:31'),
(3, '005', 'PRO-004/24', 3, 1700, 5100, '2024-04-19 16:43:14'),
(4, '005', 'PRO-001/24', 10, 3000, 30000, '2024-04-19 20:56:20'),
(6, '0001', 'PRO-002/24', 8, 2200, 17600, '2024-04-21 12:51:20'),
(8, '005', 'PRO-004/24', 100, 1700, 170000, '2024-04-21 15:04:23'),
(9, '0001', 'PRO-001/24', 100, 3000, 300000, '2024-04-21 15:43:07'),
(10, '0001', 'PRO-001/24', 15, 3000, 45000, '2024-04-21 16:18:51'),
(11, '0001', 'PRO-001/24', 5, 3000, 15000, '2024-04-21 16:20:09'),
(12, '0001', 'PRO-001/24', 10, 3000, 30000, '2024-04-21 16:21:43'),
(13, '0001', 'PRO-001/24', 10, 3000, 30000, '2024-04-21 16:26:21'),
(14, '005', 'PRO-004/24', 31, 1700, 52700, '2024-04-21 16:31:04'),
(15, '0001', 'PRO-001/24', 5, 3000, 15000, '2024-04-21 16:34:36'),
(16, '0001', 'PRO-003/24', 5, 2600, 13000, '2024-04-21 16:57:08'),
(17, '0001', 'PRO-003/24', 10, 2600, 26000, '2024-04-21 17:00:18'),
(18, '005', 'PRO-004/24', 5, 1700, 8500, '2024-04-21 17:12:13'),
(19, '0001', 'PRO-004/24', 5, 1700, 8500, '2024-04-21 17:13:35'),
(20, '0001', 'PRO-004/24', 1, 1700, 1700, '2024-04-21 17:14:38'),
(21, '0001', 'PRO-004/24', 2, 1700, 3400, '2024-04-21 17:15:26'),
(22, '0001', 'PRO-003/24', 5, 2600, 13000, '2024-04-21 17:20:21'),
(23, '005', 'PRO-001/24', 31, 3000, 93000, '2024-04-22 13:34:49'),
(24, '0001', 'PRO-001/24', 2, 3000, 6000, '2024-04-22 13:35:48'),
(25, '0001', 'PRO-001/24', 3, 3000, 9000, '2024-04-22 13:36:46'),
(26, '0001', 'PRO-001/24', 10, 3000, 30000, '2024-04-22 13:37:41'),
(27, '0001', 'PRO-001/24', 4, 3000, 12000, '2024-04-22 13:37:41'),
(28, '0001', 'PRO-002/24', 5, 2200, 11000, '2024-04-22 13:39:24'),
(29, '0001', 'PRO-002/24', 10, 2200, 22000, '2024-04-22 15:33:07'),
(30, '0001', 'PRO-001/24', 50, 3000, 150000, '2024-04-22 20:50:18'),
(31, '0001', 'PRO-004/24', 7, 1700, 11900, '2024-04-22 20:54:59'),
(32, '005', 'PRO-003/24', 2, 2600, 5200, '2024-04-22 20:54:59'),
(33, '005', 'PRO-002/24', 43, 2200, 94600, '2024-04-23 14:37:52'),
(34, '0001', 'PRO-002/24', 30, 2200, 66000, '2024-04-24 00:23:45'),
(35, '0001', 'PRO-003/24', 18, 2600, 46800, '2024-04-24 01:31:42'),
(37, '0001', 'PRO-003/24', 5, 2600, 13000, '2024-05-13 15:56:21'),
(38, '0001', 'PRO-003/24', 4, 2600, 10400, '2024-05-14 07:21:39'),
(39, '0001', 'PRO-002/24', 5, 2200, 11000, '2024-05-14 14:33:22'),
(40, '0001', 'PRO-002/24', 22, 2200, 48400, '2024-05-14 14:33:22');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`Matricule`);

--
-- Indexes for table `ventes`
--
ALTER TABLE `ventes`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Client` (`Client`),
  ADD KEY `Produit` (`Produit`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ventes`
--
ALTER TABLE `ventes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ventes`
--
ALTER TABLE `ventes`
  ADD CONSTRAINT `ventes_ibfk_1` FOREIGN KEY (`Client`) REFERENCES `clients` (`ID`),
  ADD CONSTRAINT `ventes_ibfk_2` FOREIGN KEY (`Produit`) REFERENCES `produits` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
