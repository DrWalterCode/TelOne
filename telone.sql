/*
 Navicat Premium Data Transfer

 Source Server         : MySQL Databases
 Source Server Type    : MySQL
 Source Server Version : 50720
 Source Host           : localhost:3306
 Source Schema         : telone

 Target Server Type    : MySQL
 Target Server Version : 50720
 File Encoding         : 65001

 Date: 13/01/2018 12:05:44
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for audit
-- ----------------------------
DROP TABLE IF EXISTS `audit`;
CREATE TABLE `audit`  (
  `logID` int(11) NOT NULL AUTO_INCREMENT,
  `loginDate` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `loginTime` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `logoutDate` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `logoutTime` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `username` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  PRIMARY KEY (`logID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 49 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of audit
-- ----------------------------
INSERT INTO `audit` VALUES (1, '29.12.2017', '13:10:01', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (2, '29.12.2017', '13:11:46', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (3, '29.12.2017', '13:12:17', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (4, '29.12.2017', '13:21:06', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (5, '29.12.2017', '13:22:24', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (6, '29.12.2017', '13:39:56', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (7, '29.12.2017', '13:44:59', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (8, '29.12.2017', '13:54:58', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (9, '29.12.2017', '13:58:46', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (10, '29.12.2017', '13:59:10', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (11, '29.12.2017', '14:10:20', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (12, '29.12.2017', '14:23:05', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (13, '29.12.2017', '14:25:09', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (14, '29.12.2017', '14:33:19', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (15, '29.12.2017', '15:02:34', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (16, '29.12.2017', '15:29:31', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (17, '29.12.2017', '15:47:08', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (18, '29.12.2017', '16:18:33', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (19, '29.12.2017', '16:19:40', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (20, '29.12.2017', '16:21:40', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (21, '29.12.2017', '16:36:14', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (22, '29.12.2017', '16:44:51', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (23, '09.01.2018', '10:36:49', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (24, '09.01.2018', '11:08:06', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (25, '09.01.2018', '11:10:48', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (26, '09.01.2018', '11:15:35', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (27, '09.01.2018', '14:23:48', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (28, '09.01.2018', '14:31:04', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (29, '09.01.2018', '14:45:13', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (30, '09.01.2018', '14:55:25', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (31, '09.01.2018', '15:08:48', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (32, '09.01.2018', '15:58:29', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (33, '09.01.2018', '16:31:10', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (34, '09.01.2018', '16:32:49', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (35, '09.01.2018', '16:33:46', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (36, '09.01.2018', '16:36:07', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (37, '09.01.2018', '16:38:14', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (38, '09.01.2018', '16:38:57', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (39, '09.01.2018', '16:40:28', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (40, '09.01.2018', '16:43:02', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (41, '09.01.2018', '16:44:05', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (42, '13.01.2018', '10:39:30', 'LOGGED IN', 'LOGGED IN', 'USERNUMBER');
INSERT INTO `audit` VALUES (43, '13.01.2018', '10:40:25', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (44, '13.01.2018', '11:27:51', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (45, '13.01.2018', '11:51:37', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (46, '13.01.2018', '11:52:26', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (47, '13.01.2018', '11:54:24', 'LOGGED IN', 'LOGGED IN', '773130145');
INSERT INTO `audit` VALUES (48, '13.01.2018', '11:56:42', 'LOGGED IN', 'LOGGED IN', '773130145');

-- ----------------------------
-- Table structure for database_connection
-- ----------------------------
DROP TABLE IF EXISTS `database_connection`;
CREATE TABLE `database_connection`  (
  `computer_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `host` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `date_set` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0),
  `connection_status` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT '',
  PRIMARY KEY (`computer_name`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of database_connection
-- ----------------------------
INSERT INTO `database_connection` VALUES ('DrWalter', 'localhost', 'root', 'root', '2017-12-29 11:04:18', 'Active');

-- ----------------------------
-- Table structure for payments
-- ----------------------------
DROP TABLE IF EXISTS `payments`;
CREATE TABLE `payments`  (
  `paymentID` int(11) NOT NULL AUTO_INCREMENT,
  `amount` decimal(10, 2) NULL DEFAULT NULL,
  `paymentdate` datetime(0) NULL DEFAULT NULL,
  `package` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `data` decimal(10, 0) NULL DEFAULT NULL,
  `usernumber` int(11) NULL DEFAULT NULL,
  `paymentmonth` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`paymentID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of payments
-- ----------------------------
INSERT INTO `payments` VALUES (1, 25.00, '2018-01-09 14:24:22', 'Home Plus', 30000, 773130145, 'January');
INSERT INTO `payments` VALUES (2, 25.00, '2018-01-09 14:31:08', 'Home Plus', 30000, 773130145, 'January');
INSERT INTO `payments` VALUES (3, 42.00, '2018-01-09 14:45:50', 'Home Premier', 60000, 773130145, 'January');
INSERT INTO `payments` VALUES (4, 25.00, '2018-01-09 14:55:31', 'Home Plus', 30000, 773130145, 'January');
INSERT INTO `payments` VALUES (5, 89.00, '2018-01-13 11:28:56', 'Infinity Pro', 1000000, 773130144, 'January');

-- ----------------------------
-- Table structure for points
-- ----------------------------
DROP TABLE IF EXISTS `points`;
CREATE TABLE `points`  (
  `pointsID` int(11) NOT NULL AUTO_INCREMENT,
  `usernumber` int(11) NULL DEFAULT NULL,
  `point` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`pointsID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of points
-- ----------------------------
INSERT INTO `points` VALUES (1, 773130145, 10);
INSERT INTO `points` VALUES (2, 773130145, 5);
INSERT INTO `points` VALUES (3, 773130145, 30);

-- ----------------------------
-- Table structure for usages
-- ----------------------------
DROP TABLE IF EXISTS `usages`;
CREATE TABLE `usages`  (
  `usageID` int(11) NOT NULL AUTO_INCREMENT,
  `usage` double NULL DEFAULT NULL,
  `usernumber` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `usagedate` datetime(0) NULL DEFAULT NULL,
  `usagemonth` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`usageID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of usages
-- ----------------------------
INSERT INTO `usages` VALUES (1, 4.25, '773130145', '2018-01-09 16:18:22', 'January');
INSERT INTO `usages` VALUES (2, 4.44, '773130145', '2018-01-09 16:24:14', 'January');
INSERT INTO `usages` VALUES (3, 4.48, '773130145', '2018-01-09 16:27:18', 'January');
INSERT INTO `usages` VALUES (4, 8, '773130145', '2018-01-09 16:27:35', 'January');
INSERT INTO `usages` VALUES (5, 8.2, '773130145', '2018-01-09 16:29:26', 'January');
INSERT INTO `usages` VALUES (6, 0, '773130145', '2018-01-09 16:31:17', 'January');
INSERT INTO `usages` VALUES (7, 0, '773130145', '2018-01-09 16:32:52', 'January');
INSERT INTO `usages` VALUES (8, 0, '773130145', '2018-01-09 16:43:09', 'January');
INSERT INTO `usages` VALUES (9, 4.44, '773130145', '2018-01-09 18:33:29', 'January');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `usergroup` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `surname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `forename` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`user_id`) USING BTREE,
  UNIQUE INDEX `simpl`(`username`) USING BTREE,
  UNIQUE INDEX `Duplicate cell`(`phone`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 'admin', '773130144', 'admin', NULL, NULL, NULL, '+263773130146');
INSERT INTO `users` VALUES (15, 'CLIENT', '773130145', 'client', '', '', '', '+263773130145');

-- ----------------------------
-- View structure for currentmonth_usage_view
-- ----------------------------
DROP VIEW IF EXISTS `currentmonth_usage_view`;
CREATE ALGORITHM = UNDEFINED DEFINER = `root`@`localhost` SQL SECURITY DEFINER VIEW `currentmonth_usage_view` AS select ifnull(sum(`usages`.`usage`),0) AS `usage`,ifnull(sum(`payments`.`data`),0) AS `data`,`payments`.`usernumber` AS `usernumber`,`payments`.`paymentmonth` AS `paymentmonth` from (`payments` left join `usages` on((`usages`.`usernumber` = `payments`.`usernumber`))) group by `payments`.`usernumber`,`payments`.`paymentmonth`;

-- ----------------------------
-- View structure for leaderboard
-- ----------------------------
DROP VIEW IF EXISTS `leaderboard`;
CREATE ALGORITHM = UNDEFINED DEFINER = `root`@`localhost` SQL SECURITY DEFINER VIEW `leaderboard` AS select `points`.`usernumber` AS `usernumber`,sum(`points`.`point`) AS `points` from `points` group by `points`.`usernumber` limit 10;

-- ----------------------------
-- Triggers structure for table payments
-- ----------------------------
DROP TRIGGER IF EXISTS `insertdate`;
delimiter ;;
CREATE TRIGGER `insertdate` BEFORE INSERT ON `payments` FOR EACH ROW SET NEW.paymentdate = NOW()
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table payments
-- ----------------------------
DROP TRIGGER IF EXISTS `insertmonth`;
delimiter ;;
CREATE TRIGGER `insertmonth` BEFORE INSERT ON `payments` FOR EACH ROW SET NEW.paymentmonth = MONTHNAME(new.paymentdate)
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table usages
-- ----------------------------
DROP TRIGGER IF EXISTS `insertdate2`;
delimiter ;;
CREATE TRIGGER `insertdate2` BEFORE INSERT ON `usages` FOR EACH ROW SET NEW.usagedate = NOW()
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table usages
-- ----------------------------
DROP TRIGGER IF EXISTS `insertmonth2`;
delimiter ;;
CREATE TRIGGER `insertmonth2` BEFORE INSERT ON `usages` FOR EACH ROW SET NEW.usagemonth = MONTHNAME(new.usagedate)
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
