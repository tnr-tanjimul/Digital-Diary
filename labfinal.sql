-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2020 at 06:03 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `labfinal`
--

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `event_id` int(11) NOT NULL,
  `description` varchar(1000) NOT NULL,
  `person_id` int(11) NOT NULL,
  `importance` varchar(50) NOT NULL,
  `event_date` varchar(50) NOT NULL,
  `updated_date` varchar(50) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`event_id`, `description`, `person_id`, `importance`, `event_date`, `updated_date`) VALUES
(4, 'Live Class', 1, 'High', '05/10/2020 9:17:04 AM', '05/10/2020 12:24:10 PM'),
(5, 'henfa khatun', 2, 'Less important', '05/01/2020 9:17:04 AM', '05/10/2020 9:56:30 AM'),
(7, 'Review Class Today', 4, 'High', '05/11/2020 9:17:04 AM', '05/10/2020 10:56:27 AM'),
(8, 'My birthday', 4, 'Moderate', '05/29/2020 9:17:04 AM', '05/10/2020 10:56:57 AM'),
(10, 'Project', 1, 'High', '05/17/2020 9:17:04 AM', '05/10/2020 12:35:48 PM'),
(11, 'betjtj', 1, 'Less important', '05/10/2020 9:17:04 AM', '05/10/2020 12:42:04 PM'),
(12, 'ami aj video edit krbo', 7, 'High', '05/10/2020 9:17:04 AM', '05/10/2020 11:05:24 PM');

-- --------------------------------------------------------

--
-- Table structure for table `persons`
--

CREATE TABLE `persons` (
  `person_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `persons`
--

INSERT INTO `persons` (`person_id`, `username`, `password`) VALUES
(1, 'tanjim', '12345'),
(3, 'azim', '001122'),
(4, 'admin', '112233'),
(5, 'tamim', '001122'),
(6, 'test', 'test'),
(7, 'tnr', '2020');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`event_id`);

--
-- Indexes for table `persons`
--
ALTER TABLE `persons`
  ADD PRIMARY KEY (`person_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `event_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `persons`
--
ALTER TABLE `persons`
  MODIFY `person_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
