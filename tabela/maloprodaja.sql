-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2021 at 02:59 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `maloprodaja`
--

-- --------------------------------------------------------

--
-- Table structure for table `proizvodi`
--

CREATE TABLE `proizvodi` (
  `id` int(10) UNSIGNED NOT NULL,
  `naziv_artikla` varchar(120) NOT NULL,
  `cena_artikla` int(11) NOT NULL,
  `mera_artikla` varchar(80) NOT NULL,
  `kategorijaID` varchar(80) NOT NULL,
  `ukupna_kolicina` int(11) NOT NULL DEFAULT 100
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `proizvodi`
--

INSERT INTO `proizvodi` (`id`, `naziv_artikla`, `cena_artikla`, `mera_artikla`, `kategorijaID`, `ukupna_kolicina`) VALUES
(1, 'Sampon za kosu', 150, '200 ml', 'Kozmetika', 300),
(2, 'Krema za lice', 200, '100 g', 'Kozmetika', 100),
(3, 'Banane', 50, '20 g', 'Pijaca', 500),
(9, 'Punjac', 500, '1 kom', 'Tehnika', 100),
(10, 'Pena za brijanje', 350, '1 boca', 'Kozmetika', 100),
(11, 'Jaja', 50, '1 kutija', 'Pijaca', 100),
(12, 'Slusalice', 3500, '1 pakovanje', 'Tehnika', 100),
(13, 'Kacket', 750, '1 kom', 'Odeca', 100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `proizvodi`
--
ALTER TABLE `proizvodi`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `naziv_artikla` (`naziv_artikla`),
  ADD KEY `kategorijaID` (`kategorijaID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `proizvodi`
--
ALTER TABLE `proizvodi`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
