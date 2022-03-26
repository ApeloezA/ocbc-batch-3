-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Mar 2022 pada 11.00
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_staff`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_staff`
--

CREATE TABLE `data_staff` (
  `nik` int(11) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `handphone` varchar(15) DEFAULT NULL,
  `joindate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `data_staff`
--

INSERT INTO `data_staff` (`nik`, `nama`, `alamat`, `handphone`, `joindate`) VALUES
(111, 'Andi', 'Jakarta', '089500000001', NULL),
(112, 'Budi', 'Depok', '089500000002', NULL),
(113, 'Ucup Depok', 'Depok', '089500000003', NULL),
(114, 'Udin Jakarta', 'Jakarta', '089500000004', Null),
(115, 'Eko Jakarta', 'Jakarta', '089500000005', Null);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
