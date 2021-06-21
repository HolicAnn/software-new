/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 80022
Source Host           : localhost:3306
Source Database       : asp

Target Server Type    : MYSQL
Target Server Version : 80022
File Encoding         : 65001

Date: 2020-12-23 18:03:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for item
-- ----------------------------
DROP TABLE IF EXISTS `item`;
CREATE TABLE `item` (
  `itemid` varchar(255) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `type` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `memo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `skill` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `userid` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `sdate` varchar(255) NOT NULL,
  `edate` varchar(255) NOT NULL,
  `status` int NOT NULL,
  `is_deal` int NOT NULL,
  PRIMARY KEY (`itemid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of item
-- ----------------------------
INSERT INTO `item` VALUES ('147638', 'app', '开发一款模板游戏', '测试项目1', 'android', '蒋仁雨', '2020-12-21', '2021-03-01', '1', '0');
INSERT INTO `item` VALUES ('263799', 'web网站', '开发一款线上直播教育类网站！', '线上学吧', 'node.js', '蒋新', '2020-12-21', '2021-04-01', '1', '0');
INSERT INTO `item` VALUES ('266733', 'app', '开发一款模板游戏哈哈哈哈啊', '王者荣耀', 'android', '', '2020-12-21', '2021-08-01', '1', '0');
INSERT INTO `item` VALUES ('274895', 'app', '测试项目介绍1232354354', '测试项目4', 'asp.net', '戴传志', '2020-12-21', '2021-03-01', '1', '0');
INSERT INTO `item` VALUES ('351848', '小程序', 'asc测试项目1231233123', 'asp测试项目1231233123', 'java', '蒋秉峰', '2020-12-23', '2021-01-01', '1', '0');
INSERT INTO `item` VALUES ('490421', '小程序', '测试项目5介绍1232435', '测试项目5', 'asp.net', '戴传志', '2020-12-21', '2021-03-01', '1', '0');
INSERT INTO `item` VALUES ('675605', 'app', '开发一款射击类游戏', '测试项目1', 'android', '蒋新', '2020-12-21', '2021-03-01', '1', '0');
INSERT INTO `item` VALUES ('791510', '系统构建', '开发一个统一的综合门户系统，实现单点登录', '测试项目3', 'android', '蒋仁雨', '2020-12-21', '2021-08-01', '1', '0');
INSERT INTO `item` VALUES ('825039', '系统构建', '开发一个适用于网络文件传输的ftp系统', 'linux-ftp系统', 'linux', '蒋新', '2020-12-21', '2021-03-01', '1', '1');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `userid` varchar(255) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `sex` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `birthday` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `skill` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `filepath` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `role` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `code` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('232323', '蒋仁雨', '123123123@qq.com', '123123', '18851791082', '男', '2000-01-01', 'android', '1', '0', null);
INSERT INTO `user` VALUES ('349900', '蒋新', '123123@qq.com', '123123', '17314985112', '男', '2020-01-01', 'node.js', '1', '1', null);
INSERT INTO `user` VALUES ('565656', '蒋秉峰', '123123@qq.com', '123123', '17314985110', '男', '2020-01-01', 'asp.net', '1', '0', null);
INSERT INTO `user` VALUES ('787878', '戴传志', '123123@qq.com', '123123', '17214985110', '男', '2020-01-01', 'asp.net', '1', '0', null);

-- ----------------------------
-- Table structure for work
-- ----------------------------
DROP TABLE IF EXISTS `work`;
CREATE TABLE `work` (
  `workid` varchar(255) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `itemid` varchar(255) NOT NULL,
  `sdate` varchar(255) NOT NULL,
  `edate` varchar(255) NOT NULL,
  `userid` varchar(255) NOT NULL,
  `memo` varchar(255) NOT NULL,
  `priority` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  PRIMARY KEY (`workid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of work
-- ----------------------------
INSERT INTO `work` VALUES ('277288', '883791', '2020-12-21', '2020-12-26', '蒋秉峰', '测试计划123123123', '重要-2', '1');
INSERT INTO `work` VALUES ('304386', '883791', '2020-12-21', '2020-12-26', '蒋秉峰', '电子商务ppt', '严重-3', '1');
INSERT INTO `work` VALUES ('321601', '791510', '2020-12-21', '2020-12-26', '蒋仁雨', '王者荣耀功能设计文档', '严重-3', '1');
INSERT INTO `work` VALUES ('470366', '266733', '2020-12-21', '2020-12-26', '蒋新', '功能设计文档', '严重-3', '1');
INSERT INTO `work` VALUES ('502793', '964930', '2020-12-23', '2020-12-31', '张三', 'asp测试计划123123', '重要-2', '1');
INSERT INTO `work` VALUES ('659168', '274895', '2020-12-21', '2020-12-26', '戴传志', '测试项目计划1', '严重-3', '1');
INSERT INTO `work` VALUES ('796941', '825039', '2020-12-21', '2020-12-26', '蒋新', 'ftp功能设计书', '一般-1', '0');
