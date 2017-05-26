-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2017 at 09:03 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ltw2_cuoiky`
--

-- --------------------------------------------------------

--
-- Table structure for table `anh_sp`
--

CREATE TABLE `anh_sp` (
  `masp` int(3) NOT NULL,
  `tenfile` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `anh_sp`
--

INSERT INTO `anh_sp` (`masp`, `tenfile`) VALUES
(28, 'dell-inspiron-3552-v5c008w-10.gif'),
(28, 'dell-inspiron-3552-v5c008w-2.jpg'),
(28, 'dell-inspiron-3552-v5c008w-21.jpg'),
(28, 'dell-inspiron-3552-v5c008w-9.jpg'),
(29, 'dell-inspiron-3452-n3700-4gb-500gb-win10-1-2.jpg'),
(29, 'dell-inspiron-3452-n3700-4gb-500gb-win10-3.jpg'),
(29, 'dell-inspiron-3452-n3700-4gb-500gb-win10-4-2.jpg'),
(29, 'dell-inspiron-3452-n3700-4gb-500gb-win10-7-1.jpg'),
(30, 'dell-vostro-3468-i3-7100u-2.jpg'),
(30, 'dell-vostro-3468-i3-7100u-3.jpg'),
(30, 'dell-vostro-3468-i3-7100u-4.jpg'),
(30, 'dell-vostro-3468-i3-7100u-6.jpg'),
(31, 'dell-inspiron-3467-i5-7200u-c4i5107w-2-1.jpg'),
(31, 'dell-inspiron-3467-i5-7200u-c4i5107w-3-1.jpg'),
(31, 'dell-inspiron-3467-i5-7200u-c4i5107w-3.jpg'),
(31, 'dell-inspiron-3467-i5-7200u-c4i5107w-5.jpg'),
(32, 'dell-vostro-3568-xf6c62-2-1.jpg'),
(32, 'dell-vostro-3568-xf6c62-2.jpg'),
(32, 'dell-vostro-3568-xf6c62-3-1.jpg'),
(32, 'dell-vostro-3568-xf6c62-8.jpg'),
(33, 'dell-inspiron-7460-n4i5259w-5.jpg'),
(33, 'dell-inspiron-7460-n4i5259w-7.jpg'),
(33, 'dell-inspiron-7460-n4i5259w-8.jpg'),
(33, 'dell-inspiron-7460-n4i5259w-9.jpg'),
(34, 'apple-macbook-air-2015-mjve2zp-a-i5-5250u-4gb-128g-bv-6.jpg'),
(34, 'apple-macbook-air-2015-mjve2zp-a-i5-5250u-4gb-128g-bv-7.jpg'),
(34, 'apple-macbook-air-2015-mjve2zp-a-i5-5250u-4gb-128g-bv-8.jpg'),
(34, 'apple-macbook-air-2015-mjve2zp-a-i5-5250u-4gb-128g-bv-9.jpg'),
(35, 'apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-4.jpg'),
(35, 'apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-5.jpg'),
(35, 'apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-6.jpg'),
(35, 'apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-7.jpg'),
(36, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-1-1.jpg'),
(36, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-2-1.jpg'),
(36, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-4.jpg'),
(36, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-8.jpg'),
(37, 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos--1.jpg'),
(37, 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos--4.jpg'),
(37, 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos--5.jpg'),
(37, 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos-4.jpg'),
(38, 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos--4.jpg'),
(38, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-1-11.jpg'),
(38, 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-6-1.jpg'),
(38, 'apple-macbook-pro-2015-mf840zp-7.jpg'),
(39, 'apple-macbook-12-mlhf2-core-m-12g-8gb-512gb-macos--12.jpg'),
(39, 'apple-macbook-12-mlhf2-core-m-12g-8gb-512gb-macos--13.jpg'),
(39, 'apple-macbook-12-mlhf2-core-m-12g-8gb-512gb-macos--4.jpg'),
(39, 'apple-macbook-12-mlhf2-core-m-12g-8gb-512gb-macos--5.jpg'),
(40, 'macbook-pro-13-2016-khong-touch-bar1.jpg'),
(40, 'macbook-pro-13-2016-khong-touch-bar6.jpg'),
(40, 'macbook-pro-13-20162.jpg'),
(40, 'macbook-pro-13-20165.jpg'),
(41, 'asus-e402sa-wx251t-1.jpg'),
(41, 'asus-e402sa-wx251t-2.jpg'),
(41, 'asus-e402sa-wx251t-20.jpg'),
(41, 'asus-e402sa-wx251t-3.jpg'),
(42, 'asus-a540la-i3-5005u-4gb-500gb-win10-3.jpg'),
(42, 'asus-a540la-i3-5005u-4gb-500gb-win10-4-2.jpg'),
(42, 'asus-a540la-i3-5005u-4gb-500gb-win10-5.jpg'),
(42, 'asus-a540la-i3-5005u-4gb-500gb-win10-7.jpg'),
(43, 'asus-a441uv-wx039t--10.jpg'),
(43, 'asus-a441uv-wx039t--3.jpg'),
(43, 'asus-a441uv-wx039t--4.jpg'),
(43, 'asus-a441uv-wx039t--7.jpg'),
(44, 'asus-x441ua-wx055t-2.jpg'),
(44, 'asus-x441ua-wx055t-3-1.jpg'),
(44, 'asus-x441ua-wx055t-3.jpg'),
(44, 'asus-x441ua-wx055t-5-3.jpg'),
(45, 'asus-k401ub-i5-6200u-fr049t-2.jpg'),
(45, 'asus-k401ub-i5-6200u-fr049t-3.jpg'),
(45, 'asus-k401ub-i5-6200u-fr049t-4.jpg'),
(45, 'asus-k401ub-i5-6200u-fr049t-8.jpg'),
(46, 'asus-a541uv-xx228t-1-1.jpg'),
(46, 'asus-a541uv-xx228t-3-1.jpg'),
(46, 'asus-a541uv-xx228t-4-1.jpg'),
(46, 'asus-a541uv-xx228t-5.jpg'),
(47, 'hp-14-am065tu-x3b72pa-2.jpg'),
(47, 'hp-14-am065tu-x3b72pa-3.jpg'),
(47, 'hp-14-am065tu-x3b72pa-4.jpg'),
(47, 'hp-14-am065tu-x3b72pa-5.jpg'),
(48, 'hp-15-ay072tu-x3b54pa--8.jpg'),
(48, 'hp-15-ay072tu-x3b54pa--9.jpg'),
(48, 'hp-15-ay072tu-x3b54pa-2.jpg'),
(48, 'hp-15-ay072tu-x3b54pa-3.jpg'),
(49, 'hp-15-ay038tu-i3-5005u-4gb-500gb-win10-2.jpg'),
(49, 'hp-15-ay038tu-i3-5005u-4gb-500gb-win10-20.jpg'),
(49, 'hp-15-ay038tu-i3-5005u-4gb-500gb-win10-3.jpg'),
(49, 'hp-15-ay038tu-i3-5005u-4gb-500gb-win10-8.jpg'),
(50, 'hp-pavilion-x360-u103tu-y4f56pa-13.jpg'),
(50, 'hp-pavilion-x360-u103tu-y4f56pa-3.jpg'),
(50, 'hp-pavilion-x360-u103tu-y4f56pa-4.jpg'),
(50, 'hp-pavilion-x360-u103tu-y4f56pa-8.jpg'),
(51, 'hp-pavilion-15-au072tx-i7--11.jpg'),
(51, 'hp-pavilion-15-au072tx-i7--3.jpg'),
(51, 'hp-pavilion-15-au072tx-i7--4.jpg'),
(51, 'hp-pavilion-15-au072tx-i7--7.jpg'),
(52, 'hp-probook-450-g4-z6t20pa-10.jpg'),
(52, 'hp-probook-450-g4-z6t20pa-11.jpg'),
(52, 'hp-probook-450-g4-z6t20pa-2.jpg'),
(52, 'hp-probook-450-g4-z6t20pa-7.jpg'),
(53, 'hp-pavilion-15-au072tx-i7--10.jpg'),
(53, 'hp-pavilion-15-au072tx-i7--110.jpg'),
(53, 'hp-pavilion-15-au072tx-i7--4.jpg'),
(53, 'hp-pavilion-15-au072tx-i7-1.jpg'),
(54, 'lenovo-ideapad-100s--1.jpg'),
(54, 'lenovo-ideapad-100s--4.jpg'),
(54, 'lenovo-ideapad-100s--6.jpg'),
(54, 'lenovo-ideapad-100s--7.jpg'),
(55, 'lenovo-ideapad-110-14ibr-80t6006yvn-1.jpg'),
(55, 'lenovo-ideapad-110-14ibr-80t6006yvn-2.jpg'),
(55, 'lenovo-ideapad-110-14ibr-80t6006yvn-3.jpg'),
(55, 'lenovo-ideapad-110-14ibr-80t6006yvn-4.jpg'),
(56, 'lenovo-yoga-300-11ibr-80m100l5vn-1.jpg'),
(56, 'lenovo-yoga-300-11ibr-80m100l5vn-10.jpg'),
(56, 'lenovo-yoga-300-11ibr-80m100l5vn-2.jpg'),
(56, 'lenovo-yoga-300-11ibr-80m100l5vn-4.jpg'),
(57, 'lenovo-yoga-510-14isk-80s700d2vn--10.jpg'),
(57, 'lenovo-yoga-510-14isk-80s700d2vn--13.jpg'),
(57, 'lenovo-yoga-510-14isk-80s700d2vn--5.jpg'),
(57, 'lenovo-yoga-510-14isk-80s700d2vn-1.jpg'),
(58, 'lenovo-ideapad-110-15isk-80ud002qvn--10.jpg'),
(58, 'lenovo-ideapad-110-15isk-80ud002qvn--33.gif'),
(58, 'lenovo-ideapad-110-15isk-80ud002qvn--6.jpg'),
(58, 'lenovo-ideapad-310-15isk-80sm010xvn-3.jpg'),
(59, 'lenovo-ideapad-110-15isk-80ud002qvn--2.jpg'),
(59, 'lenovo-ideapad-110-15isk-80ud002qvn--330.gif'),
(59, 'lenovo-ideapad-110-15isk-80ud002qvn--4.jpg'),
(59, 'lenovo-ideapad-110-15isk-80ud002qvn--7.jpg'),
(60, 'lenovo-ideapad-710s-13isk-i5-6200u-4gb-256gb-win10--1.jpg'),
(60, 'lenovo-ideapad-710s-13isk-i5-6200u-4gb-256gb-win10--4.jpg'),
(60, 'lenovo-ideapad-710s-13isk-i5-6200u-4gb-256gb-win10--5.jpg'),
(60, 'lenovo-ideapad-710s-13isk-i5-6200u-4gb-256gb-win10--8.jpg'),
(61, 'acer-es1-431-n3060-4gb-500gb-win10--2.jpg'),
(61, 'acer-es1-431-n3060-4gb-500gb-win10--3.jpg'),
(61, 'acer-es1-431-n3060-4gb-500gb-win10--4.jpg'),
(61, 'acer-es1-431-n3060-4gb-500gb-win10--5.jpg'),
(62, 'acer-es1-533-n4200-1-1.jpg'),
(62, 'acer-es1-533-n4200-2-1.gif'),
(62, 'acer-es1-533-n4200-44.jpg'),
(62, 'acer-es1-533-n4200-6.jpg'),
(63, 'acer-aspire-z1402-39kt-i3-5005u-4gb-500gb-win102-1.jpg'),
(63, 'acer-aspire-z1402-39kt-i3-5005u-4gb-500gb-win105-1.jpg'),
(63, 'acer-aspire-z1402-39kt-i3-5005u-4gb-500gb-win106-1.jpg'),
(63, 'acer-aspire-z1402-39kt-i3-5005u-4gb-500gb-win107-1.jpg'),
(64, 'acer-v3-371-32cc-i3-5005u-4gb-500gb-win10--3.jpg'),
(64, 'acer-v3-371-32cc-i3-5005u-4gb-500gb-win10--5.jpg'),
(64, 'acer-v3-371-32cc-i3-5005u-4gb-500gb-win10--6.jpg'),
(64, 'acer-v3-371-32cc-i3-5005u-4gb-500gb-win10-1.jpg'),
(65, 'acer-aspire-e5-575-50hm-i5-6200u-4gb-500gb-win10--1.jpg'),
(65, 'acer-aspire-e5-575-50hm-i5-6200u-4gb-500gb-win10--8.jpg'),
(65, 'acer-aspire-e5-575-50hm-i5-6200u-4gb-500gb-win10--9.jpg'),
(65, 'acer-aspire-e5-575-50hm-i5-6200u-4gb-500gb-win10-1.jpg'),
(66, 'acer-aspire-f5-573g-55hv-11.jpg'),
(66, 'acer-aspire-f5-573g-55hv-2.jpg'),
(66, 'acer-aspire-f5-573g-55hv-3.jpg'),
(66, 'acer-aspire-f5-573g-55hv-6.jpg'),
(67, 'asus-k401ub-i5-6200u-fr049t-2.jpg'),
(67, 'asus-k401ub-i5-6200u-fr049t-3.jpg'),
(67, 'asus-k401ub-i5-6200u-fr049t-4.jpg'),
(67, 'asus-k401ub-i5-6200u-fr049t-8.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `cart_do_hoa`
--

CREATE TABLE `cart_do_hoa` (
  `tencartdohoa` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `dungluong` int(11) DEFAULT '0',
  `thietke` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL DEFAULT ' ',
  `an` tinyint(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `cart_do_hoa`
--

INSERT INTO `cart_do_hoa` (`tencartdohoa`, `dungluong`, `thietke`, `an`) VALUES
('AMD Radeon R5 M420', 2, 'Card đồ họa rời', 0),
('AMD Radeon R5 M430', 2, 'Card đồ họa rời', 0),
('Intel® HD Graphics', 0, 'tích hợp với RAM', 0),
('Intel® Iris™ Pro Graphics', 0, 'đồ họa tích hợp', 0),
('NVIDIA GeForce 920MX', 2, 'Card đồ họa rời', 0),
('NVIDIA GeForce 940M', 2, 'Card đồ họa rời', 0),
('NVIDIA GeForce 940MX', 2, 'Card đồ họa rời', 0),
('NVIDIA® GeForce® 840M', 2, 'rời (Optimus)', 0),
('NVIDIA® GeForce® 920M', 2, 'Cart đồ họa rời', 0);

-- --------------------------------------------------------

--
-- Table structure for table `chi_tiet_don_hang`
--

CREATE TABLE `chi_tiet_don_hang` (
  `madh` int(11) NOT NULL,
  `masp` int(11) NOT NULL,
  `soluongsp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `chi_tiet_don_hang`
--

INSERT INTO `chi_tiet_don_hang` (`madh`, `masp`, `soluongsp`) VALUES
(11, 29, 1),
(11, 60, 1),
(11, 61, 1),
(11, 63, 2),
(11, 64, 2),
(11, 66, 1),
(12, 57, 1),
(12, 63, 1),
(12, 66, 1),
(13, 30, 1),
(13, 31, 1),
(13, 35, 1),
(13, 38, 1),
(13, 40, 1);

-- --------------------------------------------------------

--
-- Table structure for table `cpu`
--

CREATE TABLE `cpu` (
  `hangsx` varchar(8) COLLATE utf8_vietnamese_ci NOT NULL,
  `congnghe` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `maloai` varchar(6) COLLATE utf8_vietnamese_ci NOT NULL,
  `tocdo` float NOT NULL,
  `thongtinbodem` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `tocdotoida` float DEFAULT NULL,
  `an` float NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `cpu`
--

INSERT INTO `cpu` (`hangsx`, `congnghe`, `maloai`, `tocdo`, `thongtinbodem`, `tocdotoida`, `an`) VALUES
('Intel', 'Core i7 Haswell', '4510U', 2, 'Intel&reg; Smart Cache, 4 MB', 3.1, 0),
('Intel', 'Core i5', '4690K', 3.5, 'L2 6MB cache', NULL, 0),
('Intel', 'Core i7 Haswell', '4770HQ', 2.2, 'Intel&reg; Smart Cache, 6 MB', 3.4, 0),
('Intel', 'Core 3 Broadwell', '5005U', 2, '3MB, L3 Cache', NULL, 0),
('Intel', 'Core i3 Broadwell', '5020U', 2.2, 'Intel&reg; Smart Cache, 3 MB, L3 Cache', NULL, 0),
('Intel', 'Core i5 Broadwell', '5250U', 1.6, 'Intel&reg; Smart Cache, 3 MB', 2.7, 0),
('Intel', 'Core i5 Broadwell', '5257U', 2.7, 'Intel&reg; Smart Cache, 3 MB', 3.1, 0),
('Intel', 'Core i7 Haswell', '5410U', 2, 'Intel&reg; Smart Cache, 4 MB, L3 Cache', 3.1, 0),
('Intel', 'Core i7 Broadwell', '5820K', 3.3, '15MB cache, 28 PCIe', NULL, 0),
('Intel', 'Core i3', '6100', 3.7, '3MB cache', NULL, 0),
('Intel', 'Core i3 Skylake', '6100U', 2.3, 'Intel® Smart Cache, 3 MB, L3 Cache', 2.3, 0),
('Intel', 'Core i5 Skylake', '6200U', 2.3, 'Intel&reg; Smart Cache, 3MB', 2.8, 0),
('Intel', 'Core i5 Skylake', '6267U', 2.9, 'Intel&reg; Smart Cache, 4 MB', 3.3, 0),
('Intel', 'Core i7 Skylake', '6498DU', 2.5, 'Intel&reg; Smart Cache, 4 MB, L3 Cache', 3.1, 0),
('Intel', 'Core i7 Skylake', '6500U', 2.5, 'Intel&reg; Smart Cache, 4 MB, L3 Cache', 3.1, 0),
('Intel', 'Core i7 Skylake', '6700K', 4, '8MB cache', 5, 0),
('Intel', 'Core i3 Kabylake', '7100U', 2.4, 'Intel&reg; Smart Cache, 3 MB', 2.4, 0),
('Intel', 'Core i5 Kabylake', '7200U', 2.5, 'Intel&reg; Smart Cache, 3 MB, L3 Cache', 3.1, 0),
('Intel', 'Core i7 Kabylake', '7500U', 2.7, 'Intel® Smart Cache, 4 MB', 3.5, 0),
('Intel', 'Core M', 'C.M1.1', 1.1, 'Intel&reg; Smart Cache, 4 MB, L3 Cache', 2.2, 0),
('Intel', 'Core M', 'C.M1.2', 1.2, '4MB, L3 cache', 2.7, 0),
('Intel', 'Pentium', 'G3258', 3.2, '3MB cache', 4, 0),
('Intel', 'Celeron', 'N3060', 1.6, 'Intel&reg; Smart Cache, 2 MB', 2.48, 0),
('Intel', 'Pentium', 'N3700', 1.6, '2 MB', 2.42, 0),
('Intel', 'Pentium', 'N3710', 1.6, '2MB, L2 cache', 2.56, 0),
('Intel', 'Pentium', 'N4200', 1.1, '2MB, L2 Cache', 2.5, 0),
('Intel', 'Atom', 'Z3735', 1.33, 'Intel&reg; Smart Cache, 2 MB', 1.83, 0),
('Intel', 'Atom', 'Z3735F', 1.33, 'Intel&reg; Smart Cache, 2 MB', 1.83, 0);

-- --------------------------------------------------------

--
-- Table structure for table `danh_gia`
--

CREATE TABLE `danh_gia` (
  `masp` int(11) NOT NULL,
  `khachhang` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `thoigian` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `diem` int(11) DEFAULT NULL,
  `noidung` text COLLATE utf8_vietnamese_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

-- --------------------------------------------------------

--
-- Table structure for table `don_hang`
--

CREATE TABLE `don_hang` (
  `madh` int(11) NOT NULL,
  `khachhang` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `ngaygiolap` datetime NOT NULL,
  `diachinhan` varchar(128) COLLATE utf8_vietnamese_ci NOT NULL,
  `tongtien` int(11) NOT NULL,
  `dagiao` tinyint(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `don_hang`
--

INSERT INTO `don_hang` (`madh`, `khachhang`, `ngaygiolap`, `diachinhan`, `tongtien`, `dagiao`) VALUES
(11, 'admin', '2017-01-09 18:02:17', 'abcde', 83220000, 0),
(12, 'admin', '2017-01-11 05:52:37', '256 trần minh khai', 33470000, 0),
(13, 'user2', '2017-01-11 06:04:05', '36a phu long tan phu dong', 133950000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `hang_sx`
--

CREATE TABLE `hang_sx` (
  `tenhangsx` varchar(8) COLLATE utf8_vietnamese_ci NOT NULL,
  `truso` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `mota` text COLLATE utf8_vietnamese_ci NOT NULL,
  `an` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `hang_sx`
--

INSERT INTO `hang_sx` (`tenhangsx`, `truso`, `mota`, `an`) VALUES
('Acer', 'Tịch Chỉ, Tân Bắc, Đài Loan', 'Acer Inc. (còn được viết là acer hoặc trước kia là acer) hay Tập đoàn Hoành Kì là tập đoàn đa quốc gia về thiết bị điện tử và phần cứng máy tính của Đài Loan có trụ sở tại Tịch Chỉ, Tân Bắc, Đài Loan.<br/>Các sản phẩm của Acer bao gồm các loại máy tính để bàn và laptop PC, máy tính bảng, server, các thiết bị lưu trữ, màn hình hiển thị, smartphone và các thiết bị ngoại vi. Đồng thời còn cung cấp các thiết bị phục vụ thương mại điện tử cho các doanh nghiệp, chính phủ và người tiêu dùng. Năm 2013, Acer là chiếm thị phần nhà cung cấp máy tính lớn thứ 4 trên thế giới.<br/>Vào đầu những năm 2000, Acer thực hiện mô hình kinh doanh mới, chuyển từ một nhà sản xuất sang thiết kế, tiếp thị và phân phối các sản phẩm, cùng với việc thực hiện quá trình sản xuất qua hợp đồng với các đơn vị sản xuất. Ngoài việc kinh doanh chính của mình, Acer cũng sở hữu chuỗi bán lẻ máy tính đã được nhượng quyền lớn nhất tại Đài Bắc, Đài Loan.', 0),
('AMD', 'Sunnyvale, California, USA', 'AMD hay Advanced Micro Devices (NYSE:AMD) là nhà sản xuất linh kiện bán dẫn tích hợp đa quốc gia có trụ sở tại Sunnyvale, California, Hoa Kỳ. AMD là nhà sản xuất bộ vi xử lý (CPU) x86 lớn thứ hai thế giới sau Intel và là một trong những nhà sản xuất bộ nhớ flash hàng đầu trên thế giới; ngoài ra AMD còn sản xuất chipset và các linh kiện điện tử bán dẫn khác.', 0),
('Apple', 'Thung Lũng Silicon ở San Francisco, tiểu bang California', 'Apple Inc. là tập đoàn công nghệ máy tính của Mỹ có trụ sở chính đặt tại Silicon Valley (Thung Lũng Si-li-côn) ở San Francisco, tiểu bang California. Apple được thành lập ngày 1 tháng 4 năm 1976 dưới tên Apple Computer, Inc., và đổi tên thành Apple Inc. vào đầu năm 2007. Với lượng sản phẩm bán ra toàn cầu hàng năm là 13,9 tỷ đô la Mỹ (2005), 74 triệu thiết bị iPhone được bán ra chỉ trong một quý 4 năm 2014 và có hơn 98.000 nhân viên ở nhiều quốc gia, sản phẩm là máy tính I phone cá nhân, phần mềm, phần cứng, thiết bị nghe nhạc và nhiều thiết bị đa phương tiện khác.', 0),
('Asus', 'Đài Bắc, Đài Loan', 'ASUSTeK Computer Incorporated (ASUS) là một tập đoàn đa quốc gia đặt trụ sở tại Đài Loan chuyên sản xuất các mặt hàng điện tử như bo mạch chủ, máy tính xách tay, máy chủ, điện thoại di động và các sản phẩm máy tính khác. Thường được gọi là với tên thương hiệu là ASUS, công ty được niêm yết trên Sở giao dịch chứng khoán London (LSE:ASKD) và Sở giao dịch chứng khoán Đài Loan (Bản mẫu:TSE). Ngoài ra, ASUS còn sản xuất linh kiện các hãng khác (iPod, MacBook, Alienware,...).', 0),
('Dell', '1 Dell Way, Round Rock, Texas, USA', 'Dell Inc là một công ty đa quốc gia của Hoa Kỳ về phát triển và thương mại hóa công nghệ máy tính có trụ sở tại Round Rock, Texas, Hoa Kỳ. Dell được thành lập năm 1984 do Michael Dell. Đây là công ty có thu nhập lớn thứ 28 tại Hoa Kỳ.', 0),
('HP', 'Cupertino, California, Hoa Kỳ', 'Hewlett-Packard (viết tắt HP) là tập đoàn công nghệ thông tin lớn nhất thế giới. HP thành lập năm 1939 tại Palo Alto, California, Hoa Kỳ. HP hiện có trụ sở tại Cupertino, California, Hoa Kỳ. Năm 2006, tổng doanh thu của HP đạt 9.4 tỷ đô la, vượt đối thủ IBM với 9.1 tỉ, chính thức vươn lên vị trí số một(đến nay là google đứng số một) trong các công ty công nghệ thông tin.', 0),
('Intel', 'Santa Clara, California, USA', 'Tập đoàn Intel (Integrated Electronics) thành lập năm 1968 tại Santa Clara, California, Hoa Kỳ. Intel sản xuất các sản phẩm như chip vi xử lý cho máy tính, bo mạch chủ, ổ nhớ flash, card mạng và các thiết bị máy tính khác.<br/>Ban đầu, Intel là nhà sản xuất bộ nhớ SRAM và DRAM và đây là sự kiện tiêu biểu đầu tiên cho các nhà sản xuất chip bộ nhớ sau này.', 0),
('Lenovo', 'Bắc Kinh, Trung Quốc và Morrisville, Bắc Carolina, Mỹ', 'Lenovo Group Ltd. là tập đoàn đa quốc gia về công nghệ máy tính có trụ sở chính ở Bắc Kinh, Trung Quốc và Morrisville, Bắc Carolina, Mỹ.[3] Tập đoàn thiết kế, phát triển, sản xuất và bán các sản phẩm như máy tính cá nhân, máy tính bảng, smartphone, các trạm máy tính, server, thiết bị lưu trữ điện tử, phần mềm quản trị IT và ti vi thông minh.', 0),
('Toshiba', 'Tokyo, Nhật Bản', 'Công ty Toshiba  là công ty đa quốc gia công nghệ cao sản xuất thiết bị điện, có tổng hành dinh ở Tokyo (Nhật Bản). Nó là công ty thiết bị điện hợp nhất lớn thứ bảy trên thế giới.Toshiba được thành lập khi hai công ty hợp nhất vào năm 1939.', 0);

-- --------------------------------------------------------

--
-- Table structure for table `khach_hang`
--

CREATE TABLE `khach_hang` (
  `tendn` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `mk` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `hoten` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `ngsinh` date NOT NULL,
  `gioitinh` tinyint(4) NOT NULL,
  `sdt` int(11) NOT NULL,
  `email` varchar(128) COLLATE utf8_vietnamese_ci NOT NULL,
  `quyen` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `khach_hang`
--

INSERT INTO `khach_hang` (`tendn`, `mk`, `hoten`, `ngsinh`, `gioitinh`, `sdt`, `email`, `quyen`) VALUES
('admin', 'e10adc3949ba59abbe56e057f20f883e', 'Trần Thế Ngọc', '2016-12-20', 0, 947016319, 'coldboy6596@gmail.com', 0),
('admin1', 'e10adc3949ba59abbe56e057f20f883e', 'Bảo Lâm', '2016-12-20', 0, 1688788150, 'tranlebaolam@gmail.com', 1),
('user1', 'e10adc3949ba59abbe56e057f20f883e', 'Tr The Ngoc', '2017-01-01', 0, 947016319, 'coldboy6596@gmail.com', 0),
('user2', 'e10adc3949ba59abbe56e057f20f883e', 'Tran Thi Xoay', '1983-11-11', 1, 947256319, 'originaltran123@yahoo.com', 0),
('zasx', 'e10adc3949ba59abbe56e057f20f883e', 'Tram Trung QUay', '1979-12-31', 1, 942213456, 'sdfg@gmailc.com', 0);

-- --------------------------------------------------------

--
-- Table structure for table `o_dia_cung`
--

CREATE TABLE `o_dia_cung` (
  `masp` int(11) NOT NULL,
  `loaiodia` varchar(8) COLLATE utf8_vietnamese_ci NOT NULL,
  `dungluong` int(11) NOT NULL,
  `an` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `o_dia_cung`
--

INSERT INTO `o_dia_cung` (`masp`, `loaiodia`, `dungluong`, `an`) VALUES
(28, 'HDD', 500, 0),
(29, 'HDD', 500, 0),
(30, 'HDD', 1024, 0),
(31, 'HDD', 1024, 0),
(32, 'HDD', 1024, 0),
(33, 'HDD', 500, 0),
(33, 'SSD', 128, 0),
(34, 'SSD', 128, 0),
(35, 'SSD', 256, 0),
(36, 'SSD', 128, 0),
(37, 'SSD', 256, 0),
(38, 'SSD', 256, 0),
(39, 'SSD', 512, 0),
(40, 'SSD', 256, 0),
(41, 'HDD', 500, 0),
(42, 'HDD', 500, 0),
(43, 'HDD', 500, 0),
(44, 'HDD', 500, 0),
(45, 'HDD', 500, 0),
(46, 'HDD', 500, 0),
(47, 'HDD', 500, 0),
(48, 'HDD', 500, 0),
(49, 'HDD', 500, 0),
(50, 'HDD', 500, 0),
(51, 'HDD', 500, 0),
(52, 'HDD', 500, 0),
(53, 'HDD', 1024, 0),
(54, 'eMMC', 32, 0),
(55, 'HDD', 500, 0),
(56, 'eMMC', 32, 0),
(57, 'HDD', 500, 0),
(58, 'HDD', 500, 0),
(59, 'HDD', 1024, 0),
(60, 'SSD', 256, 0),
(61, 'HDD', 500, 0),
(62, 'HDD', 500, 0),
(63, 'HDD', 500, 0),
(64, 'HDD', 500, 0),
(65, 'HDD', 500, 0),
(66, 'HDD', 500, 0),
(67, 'HDD', 500, 0);

-- --------------------------------------------------------

--
-- Table structure for table `san_pham`
--

CREATE TABLE `san_pham` (
  `masp` int(3) NOT NULL,
  `tensp` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `tenhangsx` varchar(8) COLLATE utf8_vietnamese_ci NOT NULL,
  `gia` int(9) NOT NULL,
  `mau` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `icon` varchar(128) COLLATE utf8_vietnamese_ci NOT NULL,
  `loaicpu` varchar(6) COLLATE utf8_vietnamese_ci NOT NULL,
  `ramdl` int(2) NOT NULL,
  `ramloai` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `rambus` smallint(4) NOT NULL,
  `kichthuocmh` float NOT NULL,
  `dophangiai` varchar(9) COLLATE utf8_vietnamese_ci NOT NULL,
  `cnmanhinh` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `camung` tinyint(1) NOT NULL,
  `tencartdohoa` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `cnamthanh` varchar(128) COLLATE utf8_vietnamese_ci NOT NULL,
  `oquang` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `sousb` tinyint(1) NOT NULL,
  `hdmi` tinyint(1) NOT NULL,
  `cartsd` tinyint(1) NOT NULL,
  `ketnoikhac` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `chucnangkhac` varchar(128) COLLATE utf8_vietnamese_ci NOT NULL,
  `wifi` varchar(32) COLLATE utf8_vietnamese_ci NOT NULL,
  `lan` varchar(16) COLLATE utf8_vietnamese_ci NOT NULL,
  `btoothver` varchar(8) COLLATE utf8_vietnamese_ci NOT NULL,
  `camera` float NOT NULL,
  `pin` varchar(16) COLLATE utf8_vietnamese_ci NOT NULL,
  `hdh` varchar(16) COLLATE utf8_vietnamese_ci NOT NULL,
  `khoiluong` float NOT NULL,
  `dai` smallint(3) NOT NULL,
  `rong` smallint(3) NOT NULL,
  `day` smallint(3) NOT NULL,
  `chatlieu` varchar(64) COLLATE utf8_vietnamese_ci NOT NULL,
  `slcon` smallint(3) NOT NULL,
  `luotview` smallint(3) NOT NULL,
  `an` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `san_pham`
--

INSERT INTO `san_pham` (`masp`, `tensp`, `tenhangsx`, `gia`, `mau`, `icon`, `loaicpu`, `ramdl`, `ramloai`, `rambus`, `kichthuocmh`, `dophangiai`, `cnmanhinh`, `camung`, `tencartdohoa`, `cnamthanh`, `oquang`, `sousb`, `hdmi`, `cartsd`, `ketnoikhac`, `chucnangkhac`, `wifi`, `lan`, `btoothver`, `camera`, `pin`, `hdh`, `khoiluong`, `dai`, `rong`, `day`, `chatlieu`, `slcon`, `luotview`, `an`) VALUES
(28, 'Inspiron 3552', 'Dell', 6690000, 'đen', 'dell-inspiron-3552-v5c008w-400-400x400.png', 'N3060', 4, 'DDR3L (1 khe)', 1600, 15.6, '1366x768', 'HD, TrueLife LED-Backlit Display', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 3, 0, 1, '...', 'Multi TouchPad', '802.11 b/g/n', 'không', 'v4.0', 0.3, 'Li-Ion 4 cell', 'Windows 10', 2.14, 380, 260, 22, 'vỏ nhựa', 50, 11, 0),
(29, 'Inspiron 3452', 'Dell', 7290000, 'đen', 'dell-inspiron-3452-n3700-4gb-500gb-win10-den-180x125-1.png', 'N3700', 4, 'DDR3L (1 khe)', 1600, 14, '1366x768', 'HD, TrueLife LED-Backlit Display', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone', 'không', 3, 0, 1, '...', 'Multi TouchPad', '802.11 b/g/n', 'không', 'v4.0', 0.9, 'Li-Ion 4 cell', 'Windows 10', 1.9, 345, 243, 21, 'vỏ nhựa', 49, 14, 0),
(30, 'Vostro 3468', 'Dell', 11490000, 'đen', 'dell-vostro-3468-i3-7100u-400-400x460copy-400x460.png', '7100U', 4, 'DDR4 (1 khe)', 2400, 14, '1366x768', 'HD, TrueLife LED-Backlit Display', 0, 'Intel® HD Graphics', '2.0 Waves MaxxAudio, Combo Microphone & Headphone, Speakers Stereo', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Fingerprint, Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 4 cell', 'Windows 10', 1.96, 345, 243, 23, 'vỏ nhựa', 49, 28, 0),
(31, 'Inspiron 3467', 'Dell', 13490000, 'đen', 'dell-inspiron-3467-i5-7200u-c4i5107w-1-400-400x460.png', '7200U', 4, 'DDR4 (1 khe)', 2400, 14, '1366x768', 'HD, TrueLife LED-Backlit Display', 0, 'Intel® HD Graphics', '2.0 Waves MaxxAudio, Combo Microphone & Headphone, Speakers Stereo', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45)', 'Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 4 cell', 'Windows 10', 1.77, 345, 243, 21, 'vỏ nhựa', 49, 7, 0),
(32, 'Vostro 3568', 'Dell', 17490000, 'đen', 'dell-vostro-3568-xf6c62-400copycopy-400x400.png', '7500U', 4, 'DDR4 (2 khe)', 2400, 15.6, '1920x1080', 'FHD, TrueLife LED-Backlit Display, Anti-Glare', 0, 'AMD Radeon R5 M420', '2.0 Waves MaxxAudio, Combo Microphone & Headphone, Speakers Stereo', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Fingerprint, Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 4 cell', 'Windows 10', 2.18, 375, 270, 20, 'vỏ nhựa', 50, 45, 0),
(33, 'Inspiron 7460', 'Dell', 19490000, 'vàng đồng', 'dell-inspiron-7460-n4i5259w-400-400x460.png', '7200U', 4, 'DDR4 (1 khe)', 2400, 14, '1920x1080', 'FHD, TrueLife LED-Backlit Display, Công nghệ IPS, Anti-Glare', 0, 'NVIDIA GeForce 940MX', '2.0 Waves MaxxAudio, Speakers Stereo', 'không', 3, 0, 1, 'LAN (RJ45)', 'Multi TouchPad', '801.11 ac', '10/100/1000 Mbps', 'v4.2', 1, 'Li-Ion 3 cell', 'Windows 10', 1.7, 323, 227, 19, 'vỏ kim loại', 50, 4, 0),
(34, 'Air MJVM2ZP/A', 'Apple', 21990000, 'bạc', 'apple-macbook-air-2015-mjvm2zp-a-i5-5250u-4gb-128g-1-121111-400x400.png', '5250U', 4, 'DDR3L (On board)', 1600, 11.6, '1366x768', 'HD, LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Micro Kép', 'không', 2, 0, 0, 'MagSafe 2, Thunderbolt 2', '...', '802.11 a/b/g/n', 'không', 'v4.0', 1.3, 'Lithium-polymer', 'Mac OS', 1.08, 300, 192, 17, 'vỏ kim loại nguyên khối', 50, 0, 0),
(35, 'Air MMGG2ZP/A', 'Apple', 28990000, 'bạc', 'apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-400-400x400.png', '5250U', 8, 'DDR3L (On board)', 1600, 13.3, '1440x900', 'WXGA+, LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Micro Kép', 'không', 2, 0, 0, 'MagSafe 2, Thunderbolt 2', '...', '802.11 a/b/g/n', 'không', 'v4.0', 1.3, 'Lithium-polymer', 'Mac OS', 1.35, 325, 227, 17, 'vỏ kim loại nguyên khối', 49, 1, 0),
(36, 'Pro MF839ZP/A', 'Apple', 30590000, 'bạc', 'apple-macbook-pro-2015-mf839zp-a-i5-5257u-8gb-128g-detail-400x400-400x400-400x400.png', '5257U', 8, 'DDR3L (On board)', 1866, 13.3, '2560x1600', 'Retina, LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Micro Kép', 'không', 2, 0, 1, 'MagSafe 2, 2 x Thunderbolt 2', '...', '802.11 a/b/g/n', 'không', 'v4.0', 1.3, '~ 10 giờ', 'Mac OS', 1.58, 314, 219, 18, 'vỏ kim loại nguyên khối', 40, 0, 0),
(37, '12" MLH72', 'Apple', 31490000, 'xám', 'apple-macbook-12-mlh72-core-m-11g-8gb-256gb-macos-4-400x460.png', 'C.M1.1', 8, 'DDR3 (On board)', 1866, 12, '2304x1440', 'Công nghệ IPS, LED Backlit, Retina', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 0, 0, 0, 'USB Type-C', 'Force Touch, Backlit keyboard, Micro kép', '802.11 a/b/g/n/ac', 'không', 'v4.0', 1.3, '~ 10 giờ', 'Mac OS', 0.9, 281, 197, 13, 'vỏ kim loại nguyên khối', 50, 0, 0),
(38, 'Pro MF840ZP/A', 'Apple', 35990000, 'bạc', 'apple-macbook-pro-2015-mf840zp-ssd-400x400.png', '5257U', 8, 'DDR3L (On board)', 1866, 13.3, '2560x1600', 'Retina, LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Micro Kép', 'không', 2, 0, 1, 'MagSafe 2, 2 x Thunderbolt 2', '...', '802.11 a/b/g/n', 'không', 'v4.0', 1.3, '~ 10 giờ', 'Mac OS', 1.58, 314, 219, 18, 'vỏ kim loại', 49, 0, 0),
(39, '12" MLHF2', 'Apple', 37990000, 'vàng', 'apple-macbook-12-mlhf2-core-m-12g-8gb-512gb-macos-400x400.png', 'C.M1.2', 8, 'DDR3 (On board)', 1866, 12, '2304x1440', 'Công nghệ IPS, LED Backlit, Retina', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 0, 0, 0, 'USB Type-C', 'Force Touch, Backlit keyboard, Micro kép', '802.11 a/b/g/n/ac', 'không', 'v4.0', 1.3, '~ 10 giờ', 'Mac OS', 0.9, 281, 197, 13, 'vỏ kim loại', 50, 0, 0),
(40, 'Pro Touch MLVP2SA/A', 'Apple', 43990000, 'bạc', 'macbook-pro-13-2016-mlvp2sa-400-400x460-400x460.png', '6267U', 8, 'DDR4 (On board)', 2133, 13.3, '2560x1600', 'Công nghệ IPS, LED Backlit, Retina', 0, 'Intel® Iris™ Pro Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 0, 0, 0, '4 x Thunderbolt 3 (USB-C)', 'Touch Bar with integrated Touch ID sensor, Light Sensor, Backlit keyboard, Fingerprint, Force Touch, Multi TouchPad', '802.11 a/b/g/n/ac', 'không', 'v4.2', 1.3, '~ 10 giờ', 'Mac OS', 1.37, 212, 304, 15, 'vỏ kim loại nguyên khối', 49, 0, 0),
(41, 'E402SA', 'Asus', 6290000, 'xanh dương', 'asus-e402sa-wx251t-400-400x400.png', 'N3060', 2, 'DDR3 (On board)', 1600, 14, '1366x768', 'HD, ASUS Splendid Video, LED Backlit', 0, 'Intel® HD Graphics', '2.0, SonicMaster audio, Speakers Stereo, Combo Microphone & Headphone', 'không', 2, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Instant On', '802.11 b/g/n', '10/100 Mbps', 'không', 0.3, 'Li-Ion 2 cell', 'Windows 10', 1.65, 339, 235, 22, 'vỏ nhựa', 50, 0, 0),
(42, 'A540LA', 'Asus', 9990000, 'đen', 'asus-a540la-i3-5005u-4gb-500gb-win10-400-400x400.png', '5005U', 4, 'DDR3L (1 khe)', 1600, 15.6, '1366x768', 'HD, LED Backlight, ASUS Splendid Video', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 2, 0, 1, 'LAN (RJ45), VGA (D-Sub), USB Type-C', 'Instant On, Ice Cool', '802.11 b/g/n', '10/100 Mbps', 'không', 0.3, 'Li-Ion 3 cell', 'Windows 10', 1.9, 380, 252, 25, 'vỏ nhựa', 50, 1, 0),
(43, 'A441UV', 'Asus', 11490000, 'đen', 'asus-a441uv-wx039t-400x400.png', '6100U', 4, 'DDR3L (1 khe)', 1600, 14, '1366x768', 'HD, ASUS Splendid Video, LED Backlit', 0, 'NVIDIA GeForce 940MX', '2.0, SonicMaster audio, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 2, 0, 1, 'LAN (RJ45), VGA (D-Sub), USB Type-C', 'Multi TouchPad', '802.11 b/g/n', '10/100 Mbps', 'có', 0.3, 'Li-Ion 2 cell', 'Windows 10', 2, 348, 241, 32, 'vỏ nhựa', 50, 0, 0),
(44, 'X441UA', 'Asus', 12990000, 'đen', 'asus-x441ua-wx055t-400-400x400.png', '6200U', 4, 'DDR4 (1 khe)', 2133, 14, '1366x768', 'HD, LED Backlit, ASUS Splendid Video', 0, 'Intel® HD Graphics', '2.0, SonicMaster audio, Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 2, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Ice Cool', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 0.3, 'Li-Ion 3 cell', 'Windows 10', 1.75, 348, 241, 32, 'vỏ nhựa', 50, 0, 0),
(45, 'F401UB', 'Asus', 13990000, 'xám', 'asus-k401ub-i5-6200u-fr049t-400-400x460.png', '6200U', 4, 'DDR3L (On board + 1 khe)', 1600, 14, '1366x768', 'HD, LED Backlit, ASUS Splendid Video', 0, 'NVIDIA GeForce 940M', '2.0, SonicMaster audio, Speakers Stereo, Combo Microphone & Headphone', 'không', 4, 0, 1, 'LAN (RJ45)', 'Ice Cool, Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 3 cell', 'Windows 10', 1.65, 343, 241, 21, 'vỏ kim loại', 50, 6, 0),
(46, 'A541UV', 'Asus', 16290000, 'đen', 'asus-a541uv-xx228t-400-400x400.png', '6500U', 4, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, LED Backlit, ASUS Splendid Video', 0, 'NVIDIA GeForce 920MX', '2.0, SonicMaster audio, Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 2, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Ice Cool', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 0.3, 'Li-Ion 3 cell', 'Windows 10', 2, 381, 251, 28, 'vỏ nhựa', 34, 2, 0),
(47, '14 am065TU', 'HP', 6390000, 'bạc', 'hp-14-am065tu-x3b72pa-400x400-400x400.png', 'N3060', 4, 'DDR3L (1 khe)', 1600, 14, '1366x768', 'HD, Bright View, LED-backlit', 0, 'Intel® HD Graphics', '2.0, DTS Studio Sound™, Combo Microphone & Headphone, Speakers Stereo', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Multi TouchPad', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 0.9, 'Li-Ion 4 cell', 'Windows 10', 1.94, 345, 241, 24, 'vỏ nhựa', 50, 0, 0),
(48, '15 ay072TU', 'HP', 7390000, 'bạc', 'hp-15-ay072tu-x3b54pa-400-400x400.png', 'N3710', 4, 'DDR3L (1 khe)', 1600, 15.6, '1366x768', 'HD, Bright View, LED-backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45)', 'HP ProtectSmart', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 0.9, 'Li-Ion 4 cell', 'Windows 10', 2.19, 384, 254, 24, 'vỏ nhựa', 50, 0, 0),
(49, '15 ay038TU', 'HP', 9990000, 'đen', 'hp-15-ay038tu-i3-5005u-4gb-500gb-win10-1-400x460.png', '5005U', 4, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, Bright View, LED-backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45)', 'HP ProtectSmart, HP CoolSense', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 0.9, 'Li-Ion 4 cell', 'Windows 10', 2.19, 384, 254, 24, 'vỏ nhựa', 50, 0, 0),
(50, 'Pavilion x360 u103TU', 'HP', 12990000, 'vàng đồng', 'hp-pavilion-x360-u103tu-y4f56pa-400-hd-400x460-400x460-400x460.png', '7100U', 4, 'DDR4 (1 khe)', 2133, 13.3, '1366x768', 'Anti-Glare, HD BrightView LED-backlit, Lật, Xoay 360 độ', 1, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 3, 0, 1, '...', 'Multi TouchPad', '802.11 b/g/n', 'không', 'v4.0', 1, 'Li-Ion 3 cell', 'Windows 10', 1.66, 326, 222, 20, 'vỏ nhựa', 30, 3, 0),
(51, 'Pavilion 15 au067TX', 'HP', 14990000, 'vàng đồng', 'hp-pavilion-15-au067tx-400-400x400.png', '6200U', 4, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, Bright View, LED-backlit', 0, 'NVIDIA GeForce 940MX', '2.0, Bang & Olufsen audio, Speakers Stereo, HP Audio Boost', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45)', 'Multi TouchPad', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 0.9, 'Li-Ion 2 cell', 'Windows 10', 2, 383, 243, 23, 'vỏ nhựa', 49, 24, 0),
(52, 'ProBook 450', 'HP', 16490000, 'bạc', 'hp-probook-450-g4-z6t20pa-400x460-400x460.png', '7200U', 4, 'DDR4 (2 khe)', 2133, 15.6, '1920x1080', 'HD, Bright View, LED-backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'Backlit keyboard, Fingerprint, Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.2', 1, 'Li-Ion 4 cell', 'Windows 10', 2, 382, 263, 24, 'vỏ nhựa', 50, 0, 0),
(53, 'Pavilion 15 AU072TX', 'HP', 19990000, 'vàng đồng', 'hp-pavilion-15-au072tx-i7-400a-400x400.png', '6500U', 4, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, Bright View, LED-backlit', 0, 'NVIDIA GeForce 940M', '2.0, Bang & Olufsen audio, Speakers Stereo, HP Audio Boost', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45)', 'Backlit keyboard', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 1, 'Li-Ion 2 cell', 'Windows 10', 2, 383, 243, 23, 'vỏ nhựa', 49, 0, 0),
(54, 'IdeaPad 100S 11IBY', 'Lenovo', 3990000, 'đỏ, xanh dương, bạc', 'lenovo-ideapad-100s-2-400x400.png', 'Z3735F', 2, 'DDR3L (On board)', 1600, 11.6, '1366x768', 'HD, LED', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone', 'không', 2, 0, 1, 'Micro SD', 'One Key Recovery, Micro kép', '802.11 b/g/n', 'không', 'v4.0', 0.3, '2 call 8.400mAh', 'Windows 10', 1, 292, 202, 18, 'vỏ nhựa', 50, 0, 0),
(55, 'IdeaPad 100 14IBR', 'Lenovo', 5490000, 'đen', 'lenovo-ideapad-110-14ibr-80t6006yvn-400-400x400.png', 'N3060', 4, 'DDR3L (On board)', 1600, 14, '1366x768', 'HD, LED-backlit', 0, 'Intel® HD Graphics', '2.0, Dolby Home Theater, Speakers Stereo, Combo Microphone & Headphone', 'không', 2, 0, 1, 'LAN (RJ45)', 'Multi TouchPad, AccuType Keyboard', '802.11 b/g/n', '10/100 Mbps', 'v4.0', 0.3, 'Li-Ion 3 cell', 'Windows 10', 2, 340, 245, 23, 'vỏ nhựa', 50, 0, 0),
(56, 'Yoga 300 11IBR', 'Lenovo', 7990000, 'đen', 'lenovo-yoga-300-11ibr-80m100l5vn-400-400x400.png', 'N3710', 4, 'DDR3L (1 khe)', 1600, 11.6, '1366x768', 'HD, cảm ứng điện dung đa điểm, LED Backlit', 1, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone', 'không', 1, 0, 1, 'LAN (RJ45)', 'One Key Recovery, AccuType Keyboard', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 0.9, 'Li-Ion 2 cell', 'Chrome OS', 1.39, 299, 209, 22, 'vỏ nhựa', 50, 0, 0),
(57, 'Yoga 510 14ISK', 'Lenovo', 10990000, 'đen', 'lenovo-yoga-510-14isk-80s700d2vncopy-400x400.png', '6100U', 4, 'DDR4 (1 khe)', 2133, 14, '1366x768', 'HD, Công nghệ IPS, Lật, Xoay 360 độ, LED Backlit', 1, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Speakers Stereo, Audio by Harman®', 'không', 3, 0, 1, 'LAN (RJ45)', 'AccyType Keybroad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 2 cell', 'Windows 10', 1.75, 336, 232, 21, 'vỏ nhựa', 45, 48, 0),
(58, 'IdeaPad 310 15ISK', 'Lenovo', 12490000, 'đen', 'lenovo-ideapad-310-15isk-80sm010xvn-400-400x400.png', '6200U', 4, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, LED-backlit', 0, 'NVIDIA® GeForce® 920M', '2.0, Dolby Home Theater, Speakers Stereo, Combo Microphone & Headphone', 'không', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub)', 'AccyType Keybroad', '801.11 ac', '10/100/1000 Mbps', 'v4.0', 0.3, 'Li-Ion 2 cell', 'Windows 10', 2.2, 379, 260, 23, 'vỏ nhựa', 50, 0, 0),
(59, 'IdeaPad 110 15ISK', 'Lenovo', 14990000, 'đen', 'lenovo-ideapad-110-15isk-80ud002qvn-400-15inch-400x400-400x400.png', '6498DU', 8, 'DDR4 (1 khe)', 2133, 15.6, '1366x768', 'HD, LED-backlit', 0, 'AMD Radeon R5 M430', '2.0, Dolby Home Theater, Combo Microphone & Headphone', 'không', 2, 0, 1, 'LAN (RJ45)', 'Multi TouchPad, AccuType Keyboard', '801.11 ac', '10/100 Mbps', 'v4.1', 0.3, 'Li-Ion 4 cell', 'Windows 10', 2.3, 277, 264, 23, 'vỏ nhựa', 50, 1, 0),
(60, 'IdeaPad 710S 13ISK', 'Lenovo', 17990000, 'vàng đồng', 'lenovo-ideapad-710s-13isk-i5-6200u-4gb-256gb-win10-400x400copy-400x400-400x400.png', '6200U', 4, 'DDR3L (2 khe)', 1600, 13.3, '1920x1080', 'FHD, Viền màn hình mỏng, LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Speakers Stereo, Dolby Home Theater, JBL® Stereo Speakers', 'không', 2, 0, 1, 'Micro HDMI', 'One Key Recovery, AccuType Keyboard', '801.11 ac', '10/100/1000 Mbps', 'v4.0', 0.9, '~ 8 giờ', 'Windows 10', 1.2, 307, 214, 14, 'vỏ kim loại', 49, 79, 0),
(61, 'ES1 431', 'Acer', 5990000, 'đen', 'acer-es1-431-n3060-4gb-500gb-win10-400x400.png', 'N3060', 4, 'DDR3L (1 khe)', 1600, 14, '1366x768', 'HD, Active Matrix TFT Colour LCD', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone', 'không', 2, 0, 1, 'LAN (RJ45)', 'Multi TouchPad', '802.11 b/g/n', '10/100 Mbps', 'có', 0.3, 'Li-Ion 4 cell', 'Windows 10', 2.1, 346, 248, 25, 'vỏ nhựa', 49, 0, 0),
(62, 'ES1 533', 'Acer', 6990000, 'đen', 'acer-es1-533-n4200-1-400x420.png', 'N4200', 4, 'DDR3L (1 khe)', 1600, 15.6, '1366x768', 'HD, LED-backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 3, 0, 1, 'LAN (RJ45)', '...', '802.11 b/g/n', '10/100/1000 Mbps', 'không', 3, 'Li-Ion 3 cell', 'Windows 10', 2.4, 382, 258, 25, 'vỏ nhựa', 32, 36, 0),
(63, 'Aspire Z1402 39KT', 'Acer', 8490000, 'đen', 'acer-aspire-z1402-39kt-i3-5005u-4gb-500gb-win10-400b-400x400.png', '5005U', 4, 'DDR3L (1 khe)', 1600, 14, '1366x768', 'HD, ACER CineCrystal LED Backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'không', 2, 0, 1, 'LAN (RJ45)', 'Multi TouchPad', '802.11 b/g/n', '10/100 Mbps', 'không', 3, 'Li-Ion 3 cell', 'Windows 10', 2.1, 348, 245, 25, 'vỏ nhựa', 47, 32, 0),
(64, 'V3 371 32CC', 'Acer', 10490000, 'đen', 'acer-v3-371-32cc-i3-5005u-4gb-500gb-win10-400a-400x400.png', '5005U', 2, 'DDR3L (1 khe)', 1600, 13.3, '1366x768', 'HD, ACER CineCrystal LED Backlit', 0, 'Intel® HD Graphics', '2.0, Combo Microphone & Headphone, Speakers Stereo, Dolby Home Theater', 'không', 2, 0, 1, 'LAN (RJ45)', '...', '801.11 ac', '10/100/1000 Mbps', 'có', 0.9, 'Li-Ion 4 cell', 'Windows 10', 1.5, 328, 229, 20, 'vỏ nhựa - nắp lưng bằng kim loại', 48, 21, 0),
(65, 'Aspire E5 575 50HM', 'Acer', 11990000, 'đen', 'acer-aspire-e5-575-50hm-i5-6200u-4gb-500gb-win10-400-400x400.png', '6200U', 4, 'DDR4 (2 khe)', 2133, 15.6, '1920x1080', 'FHD, ACER CineCrystal LED Backlit', 0, 'Intel® HD Graphics', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub), USB Type-C', 'USB Charge', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 4 cell', 'Windows 10', 2.23, 381, 259, 30, 'vỏ nhựa', 50, 17, 0),
(66, 'Aspire F5 573G 55HV', 'Acer', 13990000, 'bạc', 'acer-aspire-f5-573g-55hv-400-400x460.png', '7200U', 4, 'DDR4 (2 khe)', 2133, 15.6, '1920x1080', 'FHD, ACER CineCrystal LED Backlit', 0, 'NVIDIA GeForce 940MX', '2.0 Speakers Stereo, Combo Microphone & Headphone', 'DVD Super Multi Double Layer', 3, 0, 1, 'LAN (RJ45), VGA (D-Sub), USB Type-C', 'Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 6 cell', 'Windows 10', 2.4, 381, 256, 25, 'vỏ nhựa - chiếu nghỉ tay bằng kim loại', 48, 4, 0),
(67, 'K401UB', 'Asus', 13990000, 'xám', 'asus-k401ub-i5-6200u-fr049t-400-400x460.png', '6200U', 4, 'DDR3L (On board + 1 khe)', 1600, 14, '1366x768', 'HD, LED-backlit, ASUS Splendid Video', 0, 'NVIDIA GeForce 940M', '2.0, SonicMaster audio, Speakers Stereo, Combo Microphone & Headphone', 'không', 4, 0, 1, 'LAN (RJ45)', 'Ice Cool, Multi TouchPad', '802.11 b/g/n', '10/100/1000 Mbps', 'v4.0', 1, 'Li-Ion 3 cell', 'Windows 10', 1.65, 343, 241, 21, 'vỏ kim loại', 50, 1, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anh_sp`
--
ALTER TABLE `anh_sp`
  ADD PRIMARY KEY (`masp`,`tenfile`);

--
-- Indexes for table `cart_do_hoa`
--
ALTER TABLE `cart_do_hoa`
  ADD PRIMARY KEY (`tencartdohoa`);

--
-- Indexes for table `chi_tiet_don_hang`
--
ALTER TABLE `chi_tiet_don_hang`
  ADD PRIMARY KEY (`madh`,`masp`),
  ADD KEY `masp` (`masp`);

--
-- Indexes for table `cpu`
--
ALTER TABLE `cpu`
  ADD PRIMARY KEY (`maloai`),
  ADD KEY `hangsx` (`hangsx`);

--
-- Indexes for table `danh_gia`
--
ALTER TABLE `danh_gia`
  ADD PRIMARY KEY (`masp`,`thoigian`),
  ADD KEY `khachhang` (`khachhang`);

--
-- Indexes for table `don_hang`
--
ALTER TABLE `don_hang`
  ADD PRIMARY KEY (`madh`),
  ADD KEY `khachhang` (`khachhang`);

--
-- Indexes for table `hang_sx`
--
ALTER TABLE `hang_sx`
  ADD PRIMARY KEY (`tenhangsx`);

--
-- Indexes for table `khach_hang`
--
ALTER TABLE `khach_hang`
  ADD PRIMARY KEY (`tendn`);

--
-- Indexes for table `o_dia_cung`
--
ALTER TABLE `o_dia_cung`
  ADD PRIMARY KEY (`masp`,`loaiodia`);

--
-- Indexes for table `san_pham`
--
ALTER TABLE `san_pham`
  ADD PRIMARY KEY (`masp`),
  ADD KEY `loaicpu` (`loaicpu`),
  ADD KEY `tencartdohoa` (`tencartdohoa`),
  ADD KEY `tencartdohoa_2` (`tencartdohoa`),
  ADD KEY `tenhangsx` (`tenhangsx`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `anh_sp`
--
ALTER TABLE `anh_sp`
  ADD CONSTRAINT `anh_sp_ibfk_1` FOREIGN KEY (`masp`) REFERENCES `san_pham` (`masp`);

--
-- Constraints for table `chi_tiet_don_hang`
--
ALTER TABLE `chi_tiet_don_hang`
  ADD CONSTRAINT `chi_tiet_don_hang_ibfk_1` FOREIGN KEY (`masp`) REFERENCES `san_pham` (`masp`),
  ADD CONSTRAINT `chi_tiet_don_hang_ibfk_2` FOREIGN KEY (`madh`) REFERENCES `don_hang` (`madh`);

--
-- Constraints for table `cpu`
--
ALTER TABLE `cpu`
  ADD CONSTRAINT `cpu_ibfk_1` FOREIGN KEY (`hangsx`) REFERENCES `hang_sx` (`tenhangsx`);

--
-- Constraints for table `danh_gia`
--
ALTER TABLE `danh_gia`
  ADD CONSTRAINT `danh_gia_ibfk_1` FOREIGN KEY (`masp`) REFERENCES `san_pham` (`masp`),
  ADD CONSTRAINT `danh_gia_ibfk_2` FOREIGN KEY (`khachhang`) REFERENCES `khach_hang` (`tendn`);

--
-- Constraints for table `don_hang`
--
ALTER TABLE `don_hang`
  ADD CONSTRAINT `don_hang_ibfk_1` FOREIGN KEY (`khachhang`) REFERENCES `khach_hang` (`tendn`);

--
-- Constraints for table `san_pham`
--
ALTER TABLE `san_pham`
  ADD CONSTRAINT `san_pham_ibfk_1` FOREIGN KEY (`masp`) REFERENCES `o_dia_cung` (`masp`),
  ADD CONSTRAINT `san_pham_ibfk_2` FOREIGN KEY (`tencartdohoa`) REFERENCES `cart_do_hoa` (`tencartdohoa`),
  ADD CONSTRAINT `san_pham_ibfk_3` FOREIGN KEY (`tenhangsx`) REFERENCES `hang_sx` (`tenhangsx`),
  ADD CONSTRAINT `san_pham_ibfk_4` FOREIGN KEY (`loaicpu`) REFERENCES `cpu` (`maloai`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
