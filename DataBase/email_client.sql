-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2021 at 01:55 PM
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
-- Table structure for table `email_archive`
--

CREATE TABLE `email_archive` (
  `from` int(11) NOT NULL,
  `to` text NOT NULL,
  `subject` text NOT NULL DEFAULT 'Benex Company',
  `emailBody` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `email_archive`
--

INSERT INTO `email_archive` (`from`, `to`, `subject`, `emailBody`) VALUES
(4, 'aks13@gmail.com', 'aerhr', 'sggrgrg'),
(4, 'mosha2@gmail.com', 'halo', 'shalom'),
(4, 'benyamin@gmailc.com', 'hah', 'ijg\r\n'),
(4, 'aksas3@gmail.com', 'dddd', 'akha13@gmail.com\r\naksa13@gmail.com\r\n'),
(4, 'aksashhh@gmail.com', 'chekc hcek', 'dfg');

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
  `dateOfSignUp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `optionalMail` varchar(50) DEFAULT NULL,
  `phoneNumber` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='stores the user registration and login data';

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `userName`, `passWord`, `firstName`, `lastName`, `dateOfSignUp`, `optionalMail`, `phoneNumber`) VALUES
(4, 'Ben77420', 'haen10', 'Bemin', 'Ben vid', '2021-01-06 16:32:50', '', '0523291'),
(5, 'Aleder', 'Alexander', 'Aleder', 'Akimzhanov', '2021-01-06 16:37:01', '', '047610');

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
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'users id number', AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
