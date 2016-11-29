-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 13, 2014 at 04:02 AM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `church_offering`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_members`
--

CREATE TABLE IF NOT EXISTS `tbl_members` (
  `member_id` int(5) NOT NULL AUTO_INCREMENT,
  `member_lname` varchar(15) NOT NULL,
  `member_fname` varchar(15) NOT NULL,
  `member_midname` varchar(10) NOT NULL,
  `member_gender` varchar(2) NOT NULL,
  `member_dob` date NOT NULL,
  `member_address` varchar(30) NOT NULL,
  `member_salvation_date` date NOT NULL,
  `member_baptism_date` date NOT NULL,
  `member_sponsor` varchar(15) NOT NULL,
  `other_details` varchar(20) NOT NULL,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=102 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member_offer`
--

CREATE TABLE IF NOT EXISTS `tbl_member_offer` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `member_id` int(5) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `date_given` date NOT NULL,
  `offer_id` varchar(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=19 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member_pledge`
--

CREATE TABLE IF NOT EXISTS `tbl_member_pledge` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `pledge_id` int(5) NOT NULL,
  `member_id` int(5) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `date_given` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `pledge_id` (`pledge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_offerings`
--

CREATE TABLE IF NOT EXISTS `tbl_offerings` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `offer_id` varchar(10) NOT NULL,
  `offer_type` varchar(20) NOT NULL,
  `other_details` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `offer_id` (`offer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pledges`
--

CREATE TABLE IF NOT EXISTS `tbl_pledges` (
  `pledge_id` int(5) NOT NULL AUTO_INCREMENT,
  `pledge_date` date NOT NULL,
  `pledge_description` varchar(10) NOT NULL,
  `pledge_amount` decimal(10,0) NOT NULL,
  `pledge_deadline` date NOT NULL,
  PRIMARY KEY (`pledge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
