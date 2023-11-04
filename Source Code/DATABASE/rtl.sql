-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 31, 2022 at 05:54 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rtl`
--

-- --------------------------------------------------------

--
-- Table structure for table `db_categories`
--

CREATE TABLE `db_categories` (
  `catid` int(11) NOT NULL,
  `catname` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_categories`
--

INSERT INTO `db_categories` (`catid`, `catname`) VALUES
(62784, 'OPPO'),
(24414, 'SAMSUNG'),
(38998, 'VIVO'),
(87412, 'NOKIA'),
(71444, 'REALME');

-- --------------------------------------------------------

--
-- Table structure for table `db_customers`
--

CREATE TABLE `db_customers` (
  `cusid` int(11) NOT NULL,
  `cusname` varchar(250) DEFAULT NULL,
  `cuscontact` varchar(250) DEFAULT NULL,
  `cusaddress` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_customers`
--

INSERT INTO `db_customers` (`cusid`, `cusname`, `cuscontact`, `cusaddress`) VALUES
(12525, 'MADHAV KAMBLE', '0000000000', 'PUNE'),
(54123, 'SHUBHAM KAMBLE', '0000000000', 'PUNE'),
(85293, 'ADITYA JADHAV', '0000000000', 'KILLARI');

-- --------------------------------------------------------

--
-- Table structure for table `db_orders`
--

CREATE TABLE `db_orders` (
  `invodate` varchar(250) DEFAULT NULL,
  `invono` varchar(250) DEFAULT NULL,
  `cusid` varchar(250) DEFAULT NULL,
  `cusname` varchar(250) DEFAULT NULL,
  `contact` varchar(250) DEFAULT NULL,
  `address` varchar(250) DEFAULT NULL,
  `grandtotal` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_orders`
--

INSERT INTO `db_orders` (`invodate`, `invono`, `cusid`, `cusname`, `contact`, `address`, `grandtotal`) VALUES
('30-Jul-22', '66284', '54123', 'SHUBHAM KAMBLE', '0000000000', 'PUNE', '144000'),
('31-Jul-22', '97312', '85293', 'ADITYA JADHAV', '0000000000', 'KILLARI', '135000'),
('31-Jul-22', '44427', '12525', 'MADHAV KAMBLE', '0000000000', 'PUNE', '130000');

-- --------------------------------------------------------

--
-- Table structure for table `db_procards`
--

CREATE TABLE `db_procards` (
  `invoid` varchar(250) DEFAULT NULL,
  `cusid` varchar(250) DEFAULT NULL,
  `proid` varchar(250) DEFAULT NULL,
  `proname` varchar(250) DEFAULT NULL,
  `proqut` varchar(250) DEFAULT NULL,
  `proprice` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_procards`
--

INSERT INTO `db_procards` (`invoid`, `cusid`, `proid`, `proname`, `proqut`, `proprice`) VALUES
('24727', '54123', '75397', 'OPPO F17', '5', '110000'),
('52139', '54123', '11555', 'VIVO V17 PRO', '8', '200000'),
('84813', '54123', '75397', 'OPPO F17', '8', '176000'),
('18779', '54123', '75397', 'OPPO F17', '58', '1276000'),
('65575', '54123', '75397', 'OPPO F17', '5', '110000'),
('11219', '54123', '75397', 'OPPO F17', '8', '176000'),
('66284', '54123', '75397', 'OPPO F17', '2', '44000'),
('66284', '54123', '11555', 'VIVO V17 PRO', '4', '100000'),
('97312', '85293', '11555', 'VIVO V17 PRO', '2', '50000'),
('97312', '85293', '43572', 'SAMSUNG M2', '3', '66000'),
('97312', '85293', '41112', 'VIVO Y9', '2', '19000'),
('44427', '12525', '58477', 'REALME NOTE 10', '2', '20000'),
('44427', '12525', '75397', 'OPPO F17', '5', '110000');

-- --------------------------------------------------------

--
-- Table structure for table `db_product`
--

CREATE TABLE `db_product` (
  `proid` int(11) NOT NULL,
  `proname` varchar(250) DEFAULT NULL,
  `proqut` varchar(250) DEFAULT NULL,
  `proprice` varchar(250) DEFAULT NULL,
  `prodesc` varchar(250) DEFAULT NULL,
  `procategorie` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_product`
--

INSERT INTO `db_product` (`proid`, `proname`, `proqut`, `proprice`, `prodesc`, `procategorie`) VALUES
(43572, 'SAMSUNG M2', '100', '22000', '8GB & 128GB', 'SAMSUNG'),
(75397, 'OPPO F17', '100', '22000', '8GB & 128GB', 'OPPO'),
(41112, 'VIVO Y9', '100', '9500', '3GB & 32GB', 'VIVO'),
(11555, 'VIVO V17 PRO', '100', '25000', '8GB & 128GB', 'VIVO'),
(58477, 'REALME NOTE 10', '50', '10000', '4GB & 64GB', 'REALME');

-- --------------------------------------------------------

--
-- Table structure for table `db_user`
--

CREATE TABLE `db_user` (
  `uid` int(11) NOT NULL,
  `username` varchar(250) DEFAULT NULL,
  `ufullname` varchar(250) DEFAULT NULL,
  `upassword` varchar(250) DEFAULT NULL,
  `umobailno` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `db_user`
--

INSERT INTO `db_user` (`uid`, `username`, `ufullname`, `upassword`, `umobailno`) VALUES
(2, 'maj123', 'MAJ', 'maj123', '0000000000'),
(3, 'ynj123', 'YNJ', 'ynj123', '0000000000');

-- --------------------------------------------------------

--
-- Stand-in structure for view `invoice_view`
-- (See below for the actual view)
--
CREATE TABLE `invoice_view` (
`invodate` varchar(250)
,`invono` varchar(250)
,`cusid` varchar(250)
,`cusname` varchar(250)
,`contact` varchar(250)
,`address` varchar(250)
,`proid` varchar(250)
,`proname` varchar(250)
,`proqut` varchar(250)
,`proprice` varchar(250)
,`grandtotal` varchar(250)
);

-- --------------------------------------------------------

--
-- Structure for view `invoice_view`
--
DROP TABLE IF EXISTS `invoice_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `invoice_view`  AS SELECT `db_orders`.`invodate` AS `invodate`, `db_orders`.`invono` AS `invono`, `db_orders`.`cusid` AS `cusid`, `db_orders`.`cusname` AS `cusname`, `db_orders`.`contact` AS `contact`, `db_orders`.`address` AS `address`, `db_procards`.`proid` AS `proid`, `db_procards`.`proname` AS `proname`, `db_procards`.`proqut` AS `proqut`, `db_procards`.`proprice` AS `proprice`, `db_orders`.`grandtotal` AS `grandtotal` FROM (`db_orders` join `db_procards` on(`db_orders`.`invono` = `db_procards`.`invoid`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `db_user`
--
ALTER TABLE `db_user`
  ADD PRIMARY KEY (`uid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `db_user`
--
ALTER TABLE `db_user`
  MODIFY `uid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
