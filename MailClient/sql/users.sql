-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2020 at 05:34 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `email_client`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL COMMENT 'users id number',
  `userName` varchar(20) NOT NULL COMMENT 'login details',
  `passWord` varchar(20) NOT NULL COMMENT 'login password',
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `dateOfBirth` date NOT NULL,
  `dateOfSignUp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `optionalMail` varchar(50) DEFAULT NULL,
  `phoneNumber` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='stores the user registration and login data';

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `userName`, `passWord`, `firstName`, `lastName`, `dateOfBirth`, `dateOfSignUp`, `optionalMail`, `phoneNumber`) VALUES
(1, 'Alex', 'Benyamin', 'alex', 'alexovich', '2021-07-01', '2020-12-22 16:06:12', 'AlexTheKing007@gmail.com', '0529999999'),
(2, 'Benyamin', 'Ben David', 'ben', 'david', '2020-12-02', '2020-12-22 16:07:24', 'AlexTheKing008@gmail.com', '0529999998');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`userName`),
  ADD UNIQUE KEY `phoneNumber` (`phoneNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'users id number', AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
