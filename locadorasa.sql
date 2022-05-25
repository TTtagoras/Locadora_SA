-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 25-Maio-2022 às 14:04
-- Versão do servidor: 5.6.20-log
-- PHP Version: 5.4.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `locadorasa`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `adiministrador`
--

CREATE TABLE IF NOT EXISTS `adiministrador` (
  `CPF` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Sobrenome` varchar(50) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Email` varchar(150) NOT NULL,
  `CNH` varchar(50) NOT NULL,
  `CEP` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `adiministrador`
--

INSERT INTO `adiministrador` (`CPF`, `Nome`, `Sobrenome`, `Senha`, `Endereco`, `Telefone`, `Email`, `CNH`, `CEP`) VALUES
('000', '00', '00', '00', '00', '+55 (00) 0 0000-0000', '00', '00', 0),
('000.000.000-00', '', '', '00', '', '', '', '', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `CPF` varchar(20) NOT NULL,
  `Nome` varchar(20) NOT NULL,
  `Sobrenome` varchar(20) NOT NULL,
  `Senha` varchar(150) NOT NULL,
  `Endereco` varchar(150) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `CNH` varchar(50) NOT NULL,
  `CEP` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`CPF`, `Nome`, `Sobrenome`, `Senha`, `Endereco`, `Telefone`, `Email`, `CNH`, `CEP`) VALUES
('000.000.000-00', '000', '00', '00', '00', '+55 (00) 0 0000-0000', '0000', '000', '00000-000'),
('555.555.555-55', '55', '55', '55', '55', '+55 (55) 5 5555-5555', '55', '55', '55555-555');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE IF NOT EXISTS `funcionarios` (
  `CPF` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Sobrenome` varchar(50) NOT NULL,
  `Senha` varchar(150) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `CNH` varchar(50) NOT NULL,
  `CEP` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`CPF`, `Nome`, `Sobrenome`, `Senha`, `Endereco`, `Telefone`, `Email`, `CNH`, `CEP`) VALUES
('000.000.000-00', '000000000000000', '000000', '000000000000000000000000', '000000000000000', '+55 (00) 0 0000-0000', '0000000000000', '00000000000000000000000000000000000000000000000000', '00000-000'),
('444.444.444-44', '55', '55', '55', '55', '+55 (55) 5 5555-5555', '55', '55', '55555-555');

-- --------------------------------------------------------

--
-- Estrutura da tabela `locados`
--

CREATE TABLE IF NOT EXISTS `locados` (
  `CPF` varchar(150) NOT NULL,
  `Placa` varchar(150) NOT NULL,
  `DataLocacao` varchar(150) NOT NULL,
  `DataDevolucao` varchar(150) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE IF NOT EXISTS `veiculos` (
  `Tamanho` varchar(50) NOT NULL,
  `Categoria` varchar(50) NOT NULL,
  `Cilindradas` varchar(50) NOT NULL,
  `GPS` varchar(50) NOT NULL,
  `TelaLcd` varchar(50) NOT NULL,
  `Fabricante` varchar(50) NOT NULL,
  `Modelo` varchar(50) NOT NULL,
  `Ano` varchar(50) NOT NULL,
  `PainelDigital` varchar(50) NOT NULL,
  `Cambio` varchar(50) NOT NULL,
  `Combustivel` varchar(50) NOT NULL,
  `DatadeFabricação` varchar(50) NOT NULL,
  `ValorCompra` varchar(50) NOT NULL,
  `Placa` varchar(50) NOT NULL,
  `locado` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `veiculos`
--

INSERT INTO `veiculos` (`Tamanho`, `Categoria`, `Cilindradas`, `GPS`, `TelaLcd`, `Fabricante`, `Modelo`, `Ano`, `PainelDigital`, `Cambio`, `Combustivel`, `DatadeFabricação`, `ValorCompra`, `Placa`, `locado`) VALUES
('00', '00', '00', '00', '00', '000', '00', '00', '00', '0', '0', '0', '0', '0', ''),
('00', '00', '00', '00', '00', '00', '00', '00', '00', '00', '00', '00', '00', '00', ''),
('11', '11', '11', '11', '11', '11', '11', '11', '11', '11', '11', '11', '11', '11', ''),
('22', '22', '22', '22', '22', '2', '22', '22', '22', '22', '22', '22', '22', '22', ''),
('32', 'bom', '8000', 'sim', 'sim', 'hotwheels', 'sedam', '1500', 'sim', 'automatico', 'gasosa', '1498', '32,65', 'jhg7895', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adiministrador`
--
ALTER TABLE `adiministrador`
 ADD UNIQUE KEY `CPF` (`CPF`);

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
 ADD UNIQUE KEY `CPF` (`CPF`), ADD UNIQUE KEY `CPF_2` (`CPF`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
 ADD UNIQUE KEY `CPF` (`CPF`);

--
-- Indexes for table `veiculos`
--
ALTER TABLE `veiculos`
 ADD UNIQUE KEY `Placa` (`Placa`), ADD UNIQUE KEY `Placa_2` (`Placa`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
