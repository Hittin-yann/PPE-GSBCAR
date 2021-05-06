-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 05 avr. 2020 à 21:51
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `employer`
--

DROP TABLE IF EXISTS `employer`;
CREATE TABLE IF NOT EXISTS `employer` (
  `matricule` varchar(10) NOT NULL,
  `prenom` varchar(60) NOT NULL,
  `nom` varchar(60) NOT NULL,
  `ville` varchar(50) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `numTel` varchar(10) NOT NULL,
  `motDePass` varchar(20) NOT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `entretien_vehicule`
--

DROP TABLE IF EXISTS `entretien_vehicule`;
CREATE TABLE IF NOT EXISTS `entretien_vehicule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type_frais` varchar(50) NOT NULL,
  `cout_frais` decimal(10,0) NOT NULL,
  `date_EntreEntretien` varchar(50) NOT NULL,
  `immatriculation` varchar(10) NOT NULL,
  `date_SortieEntretien` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ENTRETIEN_VEHICULE_VEHICULE_FK` (`immatriculation`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `entretien_vehicule`
--

INSERT INTO `entretien_vehicule` (`id`, `type_frais`, `cout_frais`, `date_EntreEntretien`, `immatriculation`, `date_SortieEntretien`) VALUES
(1, 'entretient', '200', '02/04/2020', '45AZ55', '10/04/2020'),
(2, 'Entretient total', '2000', '06/04/2020', '45AZ65', '20/04/2020'),
(3, 'Changement des roues', '1500', '20/03/2020', '45AZ65', '25/03/2020');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `diponible` tinyint(1) NOT NULL,
  `etat_vehicule_aller` varchar(50) NOT NULL,
  `etat_vehicule_retour` varchar(50) NOT NULL,
  `date_reservation` date NOT NULL,
  `date_retour` date NOT NULL,
  `km_debut` int(11) NOT NULL,
  `km_fin` int(11) NOT NULL,
  `destination` varchar(50) NOT NULL,
  `frais` decimal(10,0) NOT NULL,
  `justificatif` varchar(500) NOT NULL,
  `immatriculation` varchar(10) NOT NULL,
  `matricule` varchar(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `RESERVATION_VEHICULE_FK` (`immatriculation`),
  KEY `RESERVATION_EMPLOYER0_FK` (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `login` varchar(10) NOT NULL,
  `mot_de_passe` varchar(20) NOT NULL,
  `isAdmin` tinyint(1) NOT NULL,
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`login`, `mot_de_passe`, `isAdmin`) VALUES
('yhittin', '0550002D', 1),
('yquinet', '0550002D', 1);

-- --------------------------------------------------------

--
-- Structure de la table `vehicule`
--

DROP TABLE IF EXISTS `vehicule`;
CREATE TABLE IF NOT EXISTS `vehicule` (
  `immatriculation` varchar(10) NOT NULL,
  `model` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `etat` varchar(50) NOT NULL,
  `stockage` double NOT NULL,
  `kilometrage` int(11) NOT NULL,
  `statue` varchar(50) NOT NULL,
  `autonomie_en_km` int(11) NOT NULL,
  `prix` double NOT NULL,
  `payement` varchar(50) NOT NULL,
  `dateAchat` varchar(50) NOT NULL,
  PRIMARY KEY (`immatriculation`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `vehicule`
--

INSERT INTO `vehicule` (`immatriculation`, `model`, `type`, `etat`, `stockage`, `kilometrage`, `statue`, `autonomie_en_km`, `prix`, `payement`, `dateAchat`) VALUES
('45AZ55', 'ZOE', 'Electrique', 'Neuf', 500, 15000, 'Dispo', 1000, 279, 'Loyer', '02/02/2020'),
('45AZ65', 'CAPTURE', 'Thermique', 'Neuf', 500, 10000, 'Entretient', 1000, 500, 'Loyer', '02/02/2020');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `entretien_vehicule`
--
ALTER TABLE `entretien_vehicule`
  ADD CONSTRAINT `ENTRETIEN_VEHICULE_VEHICULE_FK` FOREIGN KEY (`immatriculation`) REFERENCES `vehicule` (`immatriculation`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `RESERVATION_EMPLOYER0_FK` FOREIGN KEY (`matricule`) REFERENCES `employer` (`matricule`),
  ADD CONSTRAINT `RESERVATION_VEHICULE_FK` FOREIGN KEY (`immatriculation`) REFERENCES `vehicule` (`immatriculation`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
