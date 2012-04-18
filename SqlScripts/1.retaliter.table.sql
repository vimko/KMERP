--描述：创建表
--作者：柯余辉
--时间：2012-04-10

-- 创建数据库

IF NOT EXISTS( SELECT * FROM sys.databases WHERE name = 'KMERPR')
	CREATE DATABASE KMERPR
GO


-------------------------------------------------------------------------------


-------操作员表

IF OBJECTPROPERTY(OBJECT_ID('operators'),'IsUserTable') = 1
	DROP TABLE operators
GO

CREATE TABLE operators
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	usercode VARCHAR(50) NOT NULL,
	fullname VARCHAR(50) DEFAULT '',
	password VARCHAR(50) DEFAULT '',
	isadmin BIT DEFAULT 0,
)

CREATE INDEX IX_operators_usercode ON operators(usercode)

INSERT INTO operators(usercode,fullname,isadmin)
VALUES('admin','管理员',1)


GO



-------------------------------------------------------------------------------
-- 服装基本信息表

IF OBJECTPROPERTY(OBJECT_ID('ptypes'),'IsUserTable') = 1
	DROP TABLE ptypes
GO

CREATE TABLE ptypes
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	fullname VARCHAR(200) NOT NULL,-- 服装名称
	usercode VARCHAR(50) NOT NULL PRIMARY KEY, -- 用户编码
	pcode VARCHAR(100),-- 商品条码
	psize VARCHAR(10),-- 服装尺寸
	color VARCHAR(20),--服装 color
	seasontype VARCHAR(100),-- 春装、夏装、秋装、冬装
	manorwoman VARCHAR(4),-- 男式，女式
	cdes VARCHAR(200)-- 描述
)

CREATE INDEX IX_ptypes_usercode ON ptypes(usercode)

GO

---------------------------------------------------------------------

--仓库
IF OBJECTPROPERTY(OBJECT_ID('stocks'),'IsUserTable') = 1
	DROP TABLE stocks
GO

CREATE TABLE stocks
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	usercode VARCHAR(50),
	fullname VARCHAR(100),
	sdes VARCHAR(200)	
)

CREATE INDEX IX_stocks_usercode ON stocks(usercode)

GO

-----------------------------------------------------------------------

-- 服装入库数据表
IF OBJECTPROPERTY(OBJECT_ID('clothinginstocks'),'IsUserTable') = 1
	DROP TABLE clothinginstocks
GO

CREATE TABLE clothinginstocks
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	pid UNIQUEIDENTIFIER NOT NULL,
	sid UNIQUEIDENTIFIER NOT NULL,
	incount INT, -- 数量
	inprice NUMERIC(18,2) NOT NULL, --进价
	minsaleprice NUMERIC(18,2) NOT NULL, -- 最低销售价
	willprice NUMERIC(18,2) NOT NULL, -- 预设销售价
	instockdate DATETIME DEFAULT CURRENT_TIMESTAMP,
	hasoutstock INT DEFAULT 0,-- 已经出库数量
)

GO


-------------------------------------------------------------------------

-- 销售报表
IF OBJECTPROPERTY(OBJECT_ID('sales'),'IsUserTable') = 1
	DROP TABLE sales
GO

CREATE TABLE sales
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	cid UNIQUEIDENTIFIER NOT NULL,		-- 服装ID
	sid UNIQUEIDENTIFIER NOT NULL,		-- 仓库ID
	pid UNIQUEIDENTIFIER NOT NULL,		-- 销售员ID
	saleprice NUMERIC(18,2) NOT NULL,	-- 销售价格
	salecount INT NOT NULL,				-- 销售数量
	totalmoney NUMERIC(18,2) NOT NULL,	-- 合计
	saledate DATETIME DEFAULT GETDATE()	-- 销售时间
	isback int							-- 是否退货
)

GO

-------------------------------------------------------------------------------

-- 销售退货表

IF OBJECTPROPERTY(OBJECT_ID('backsales'),'IsUserTable') = 1
	DROP TABLE backsales
GO


CREATE TABLE backsales
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	saleid UNIQUEIDENTIFIER NOT NULL,
	cid UNIQUEIDENTIFIER NOT NULL,
	tosid UNIQUEIDENTIFIER NOT NULL,
	backmoney DECIMAL(18,2) NOT NULL,	-- 退现
	backdate DATETIME DEFAULT GETDATE(),
)

GO




-------------------------------------------------------------------------------