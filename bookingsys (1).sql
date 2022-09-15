-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2022 at 08:24 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookingsys`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(60) NOT NULL,
  `Username` varchar(80) NOT NULL,
  `Password` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `Username`, `Password`) VALUES
(1, 'admin', 'admin'),
(2, 'eric', '1234'),
(4, 'admin2', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `Id` int(60) NOT NULL,
  `Holder` varchar(80) NOT NULL,
  `Product` varchar(60) NOT NULL,
  `Price` int(80) NOT NULL,
  `Date` varchar(60) NOT NULL,
  `Address` varchar(60) NOT NULL,
  `Total_price` int(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`Id`, `Holder`, `Product`, `Price`, `Date`, `Address`, `Total_price`) VALUES
(2, 'ericlyndert', 'mix mug', 2500, '5/28/2022', 'Falls Area1', 0),
(3, 'ericlyndert', 'BBQ Full Steak', 4500, '5/18/2022', 'Falls Area1', 49500),
(4, 'ericlyndert', '', 2500, '5/26/2022', 'Falls Area1', 2500),
(9, 'sarah', 'Chiken Wings', 3500, '5/17/2022', 'Area 15', 3500),
(10, 'sarah', 'BBQ Full Steak', 4500, '5/20/2022', 'Area 15', 27000),
(13, 'tamia', 'Ting tain', 2500, '5/17/2022', 'area49', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `handles`
--

CREATE TABLE `handles` (
  `id` int(60) NOT NULL,
  `Firstname` varchar(60) NOT NULL,
  `Surname` varchar(60) NOT NULL,
  `Username` varchar(80) NOT NULL,
  `Address` varchar(80) NOT NULL,
  `Phone` int(50) NOT NULL,
  `Password` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `handles`
--

INSERT INTO `handles` (`id`, `Firstname`, `Surname`, `Username`, `Address`, `Phone`, `Password`) VALUES
(1, 'lendert', 'manani', 'ericlyndert', 'Falls Area1', 997720900, 'l3nd37t.'),
(2, 'tamia', 'banda', 'tamia', 'area49', 997720900, '1234'),
(3, '', '', '', '', 0, ''),
(4, 'sarah', 'blue', 'Sarah', 'Area 15', 9932443, '1234'),
(5, 'young', 'kambana', 'young', 'chilinde', 997720900, 'young'),
(6, 'lendert', 'manani', 'lendert', 'chinsapo', 98839397, 'l3nd37t');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `handles`
--
ALTER TABLE `handles`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `handles`
--
ALTER TABLE `handles`
  MODIFY `id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
