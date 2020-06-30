-- -- phpMyAdmin SQL Dump
-- -- version 4.9.1
-- -- https://www.phpmyadmin.net/
-- --
-- -- Host: 127.0.0.1
-- -- Tempo de geração: 27-Jun-2020 às 04:51
-- -- Versão do servidor: 10.4.8-MariaDB
-- -- versão do PHP: 7.3.11

-- /*SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
-- SET AUTOCOMMIT = 0;
-- START TRANSACTION;
-- SET time_zone = "+00:00";


-- /*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
-- /*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
-- /*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
-- /*!40101 SET NAMES utf8mb4 */;

-- --
-- -- Banco de dados: `locadora_leo`
-- --

-- -- --------------------------------------------------------

-- --
-- -- Estrutura da tabela `clientes`
-- -- 

-- -- CREATE TABLE `clientes` (
-- --   `IdCliente` int(11) NOT NULL,
-- --   `NomeCliente` longtext NOT NULL,
-- --   `DataNascimento` longtext NOT NULL,
-- --   `CpfCliente` longtext NOT NULL,
-- --   `DiasDevolucao` int(11) NOT NULL
-- -- ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --
-- -- Extraindo dados da tabela `clientes`
-- --

-- INSERT INTO `clientes` (`IdCliente`, `NomeCliente`, `DataNascimento`, `CpfCliente`, `DiasDevolucao`) VALUES
-- (1, 'Alisson Wenceslau Junior', ' 01 / 02 / 1980 ', ' 111 . 111 . 111 - 11 ', 5),
-- (2, 'Matheus Henrique Rach', ' 02 / 02 / 1990 ', ' 222 . 222 . 222 - 22 ', 5),
-- (3, 'Leonardo B. Filipini', ' 03 / 03 / 2000 ', ' 333 . 333 . 333 - 33 ', 5),
-- (4, 'Carlos E. Floresta', ' 04 / 04 / 1970 ', ' 444 . 444 . 444 - 44 ', 5),
-- (5, 'Lucas Elmer Martins', ' 05 / 05 / 2010 ', ' 555 . 555 . 555 - 55 ', 5);

-- -- --------------------------------------------------------

-- --
-- -- Estrutura da tabela `filmes`
-- --

-- CREATE TABLE `filmes` (
--   `IdFilme` int(11) NOT NULL,
--   `Titulo` longtext NOT NULL,
--   `DataLancamento` longtext NOT NULL,
--   `Sinopse` longtext NOT NULL,
--   `ValorLocacaoFilme` double NOT NULL,
--   `EstoqueFilme` int(11) NOT NULL,
--   `FilmeLocado` int(11) NOT NULL
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --
-- -- Extraindo dados da tabela `filmes`
-- --

-- INSERT INTO `filmes` (`IdFilme`, `Titulo`, `DataLancamento`, `Sinopse`, `ValorLocacaoFilme`, `EstoqueFilme`, `FilmeLocado`) VALUES
-- (1, 'Ben Hur', '25 / 01 / 1958', 'Ben-Hur é um mercador judeu que, após um desentendimento, é condenado a viver como escravo por um amigo de juventude Messala, que é o chefe das legiões romanas da cidade. Mas uma surpreendente oportunidade de vingança surge de onde ele menos espera.', 3.99, 2, 0),
-- (2, 'Encontro Marcado', '08 / 10 / 1998', 'Quando o Anjo da Morte chega à Terra para buscar um magnata da mídia, suas experiências como mortal o levam a se apaixonar pela filha do milionário.\r\n', 3.99, 2, 0),
-- (3, 'Crash', '01 / 05 / 2004', 'Tensões raciais emergem em uma série de histórias envolvendo moradores de Los Angeles. Diversos personagens das mais variadas origens étnicas se cruzam em um incidente.', 4.99, 3, 0),
-- (4, 'Kick Ass - Quebrando Tudo', ' 18 / 06 / 2010 ', 'Usando sua paixão por histórias em quadrinhos, o adolescente Dave Lizewski decide se reinventar como super-herói, apesar da total falta de poderes especiais.', 5.99, 2, 0),
-- (5, 'John Wick - De Volta Ao Jogo', ' 15 / 12 / 2014 ', 'Keanu Reeves interpreta John Wick, um assassino aposentado que busca vingança pelo assassinato do cachorro que sua esposa recentemente faleceu.', 4.99, 3, 0);

-- -- --------------------------------------------------------

-- --
-- -- Estrutura da tabela `locacaofilme`
-- --

-- CREATE TABLE `locacaofilme` (
--   `Id` int(11) NOT NULL,
--   `IdLocacao` int(11) NOT NULL,
--   `LocacaoIdLocacao` int(11) DEFAULT NULL,
--   `IdFilme` int(11) NOT NULL,
--   `FilmeIdFilme` int(11) DEFAULT NULL
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --
-- -- Extraindo dados da tabela `locacaofilme`
-- --

-- INSERT INTO `locacaofilme` (`Id`, `IdLocacao`, `LocacaoIdLocacao`, `IdFilme`, `FilmeIdFilme`) VALUES
-- (1, 1, NULL, 1, NULL),
-- (2, 1, NULL, 2, NULL),
-- (3, 2, NULL, 3, NULL),
-- (4, 2, NULL, 4, NULL),
-- (5, 2, NULL, 5, NULL);

-- -- --------------------------------------------------------

-- --
-- -- Estrutura da tabela `locacoes`
-- --

-- CREATE TABLE `locacoes` (
--   `IdLocacao` int(11) NOT NULL,
--   `ClienteIdCliente` int(11) DEFAULT NULL,
--   `DataLocacao` datetime(6) NOT NULL,
--   `IdCliente` int(11) NOT NULL DEFAULT 0
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --
-- -- Extraindo dados da tabela `locacoes`
-- --

-- INSERT INTO `locacoes` (`IdLocacao`, `ClienteIdCliente`, `DataLocacao`, `IdCliente`) VALUES
-- (1, NULL, '2020-06-26 23:40:17.688333', 1),
-- (2, NULL, '2020-06-26 23:40:45.009294', 3);

-- -- --------------------------------------------------------

-- --
-- -- Estrutura da tabela `__efmigrationshistory`
-- --

-- CREATE TABLE `__efmigrationshistory` (
--   `MigrationId` varchar(95) NOT NULL,
--   `ProductVersion` varchar(32) NOT NULL
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --
-- -- Extraindo dados da tabela `__efmigrationshistory`
-- --

-- INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
-- ('20200406232609_Migracao', '3.1.2'),
-- ('20200407223848_CriaRelacao', '3.1.2'),
-- ('20200407232746_RelacaoBd', '3.1.2');

-- --
-- -- Índices para tabelas despejadas
-- --

-- --
-- -- Índices para tabela `clientes`
-- --
-- ALTER TABLE `clientes`
--   ADD PRIMARY KEY (`IdCliente`);

-- --
-- -- Índices para tabela `filmes`
-- --
-- ALTER TABLE `filmes`
--   ADD PRIMARY KEY (`IdFilme`);

-- --
-- -- Índices para tabela `locacaofilme`
-- --
-- ALTER TABLE `locacaofilme`
--   ADD PRIMARY KEY (`Id`),
--   ADD KEY `IX_LocacaoFilme_FilmeIdFilme` (`FilmeIdFilme`),
--   ADD KEY `IX_LocacaoFilme_LocacaoIdLocacao` (`LocacaoIdLocacao`);

-- --
-- -- Índices para tabela `locacoes`
-- --
-- ALTER TABLE `locacoes`
--   ADD PRIMARY KEY (`IdLocacao`),
--   ADD KEY `IX_Locacoes_ClienteIdCliente` (`ClienteIdCliente`);

-- --
-- -- Índices para tabela `__efmigrationshistory`
-- --
-- ALTER TABLE `__efmigrationshistory`
--   ADD PRIMARY KEY (`MigrationId`);

-- --
-- -- AUTO_INCREMENT de tabelas despejadas
-- --

-- --
-- -- AUTO_INCREMENT de tabela `clientes`
-- --
-- ALTER TABLE `clientes`
--   MODIFY `IdCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

-- --
-- -- AUTO_INCREMENT de tabela `filmes`
-- --
-- ALTER TABLE `filmes`
--   MODIFY `IdFilme` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

-- --
-- -- AUTO_INCREMENT de tabela `locacaofilme`
-- --
-- ALTER TABLE `locacaofilme`
--   MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

-- --
-- -- AUTO_INCREMENT de tabela `locacoes`
-- --
-- ALTER TABLE `locacoes`
--   MODIFY `IdLocacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

-- --
-- -- Restrições para despejos de tabelas
-- --

-- --
-- -- Limitadores para a tabela `locacaofilme`
-- --
-- ALTER TABLE `locacaofilme`
--   ADD CONSTRAINT `FK_LocacaoFilme_Filmes_FilmeIdFilme` FOREIGN KEY (`FilmeIdFilme`) REFERENCES `filmes` (`IdFilme`),
--   ADD CONSTRAINT `FK_LocacaoFilme_Locacoes_LocacaoIdLocacao` FOREIGN KEY (`LocacaoIdLocacao`) REFERENCES `locacoes` (`IdLocacao`);

-- --
-- -- Limitadores para a tabela `locacoes`
-- --
-- ALTER TABLE `locacoes`
--   ADD CONSTRAINT `FK_Locacoes_Clientes_ClienteIdCliente` FOREIGN KEY (`ClienteIdCliente`) REFERENCES `clientes` (`IdCliente`);
-- COMMIT;

-- /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
-- /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
-- /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
