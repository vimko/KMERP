--������������
--���ߣ������
--ʱ�䣺2012-04-10

-- �������ݿ�

IF NOT EXISTS( SELECT * FROM sys.databases WHERE name = 'KMERPH')
	CREATE DATABASE KMERPH
GO


-------------------------------------------------------------------------------

-- �л����ݿ�
USE KMERPH
GO


-------------------------------------------------------------------------------


-------����Ա��

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
VALUES('admin','����Ա',1)


GO

-------------------------------------------------------------------------------

-- �ͻ�������Ϣ

IF OBJECTPROPERTY(OBJECT_ID('buyerinfos'),'IsUserTable') = 1
	DROP TABLE buyerinfos
GO

CREATE TABLE buyerinfos
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	usercode VARCHAR(50) NOT NULL,			-- �Զ���ͻ�����
	fullname VARCHAR(50) NOT NULL,			-- �ͻ�����
	address VARCHAR(100),					-- �ͻ���ַ
	tel VARCHAR(50),						-- ��ϵ��ʽ
	odes VARCHAR(200),
	cdatetime DATETIME DEFAULT GETDATE(),
)

GO


-------------------------------------------------------------------------------
-- ��װ������Ϣ��

IF OBJECTPROPERTY(OBJECT_ID('ptypes'),'IsUserTable') = 1
	DROP TABLE ptypes
GO

CREATE TABLE ptypes
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	fullname VARCHAR(200) NOT NULL,-- ��װ����
	usercode VARCHAR(50) NOT NULL, -- �û�����
	pcode VARCHAR(100),-- ��Ʒ����
	psize VARCHAR(10),-- ��װ�ߴ�
	color VARCHAR(20),--��װ color
	seasontype VARCHAR(100),-- ��װ����װ����װ����װ
	manorwoman VARCHAR(4),-- ��ʽ��Ůʽ
	cdes VARCHAR(200),-- ����
	cdatetime DATETIME,
	
)

CREATE INDEX IX_ptypes_usercode ON ptypes(usercode)

GO

---------------------------------------------------------------------

--�ֿ�
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

-- ��װ������ݱ�
IF OBJECTPROPERTY(OBJECT_ID('clothinginstocks'),'IsUserTable') = 1
	DROP TABLE clothinginstocks
GO

CREATE TABLE clothinginstocks
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	pid UNIQUEIDENTIFIER NOT NULL,
	sid UNIQUEIDENTIFIER NOT NULL,
	incount INT, -- ����
	inprice NUMERIC(18,2) NOT NULL, --����
	minsaleprice NUMERIC(18,2) NOT NULL, -- ������ۼ�
	willprice NUMERIC(18,2) NOT NULL, -- Ԥ�����ۼ�
	instockdate DATETIME DEFAULT CURRENT_TIMESTAMP,
	hasoutstock INT DEFAULT 0,-- �Ѿ���������
)

GO


------------------------------------------------------------------------

-- ��װ����

IF OBJECTPROPERTY(OBJECT_ID('batsales'),'IsUserTable') = 1
	DROP TABLE batsales
GO

CREATE TABLE batsales
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	pid UNIQUEIDENTIFIER NOT NULL, -- ��װID
	sid UNIQUEIDENTIFIER NOT NULL, -- �ֿ�ID
	bid UNIQUEIDENTIFIER NOT NULL,-- �ͻ�ID
	saleprice NUMERIC(18,2) NOT NULL, --���ۼ۸�
	salecount INT NOT NULL,--��������
	totalmoney NUMERIC(18,2),--�ܼ�
	saledate DATETIME DEFAULT CURRENT_TIMESTAMP,--����ʱ��
)

GO
-------------------------------------------------------------------------

-- ���۱���
IF OBJECTPROPERTY(OBJECT_ID('sales'),'IsUserTable') = 1
	DROP TABLE sales
GO

CREATE TABLE sales
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	cid UNIQUEIDENTIFIER NOT NULL,		-- ��װID
	sid UNIQUEIDENTIFIER NOT NULL,		-- �ֿ�ID
	pid UNIQUEIDENTIFIER NOT NULL,		-- ����ԱID
	saleprice NUMERIC(18,2) NOT NULL,	-- ���ۼ۸�
	salecount INT NOT NULL,				-- ��������
	totalmoney NUMERIC(18,2) NOT NULL,	-- �ϼ�
	saledate DATETIME DEFAULT GETDATE()	-- ����ʱ��
	isback int							-- �Ƿ��˻�
)

GO

-------------------------------------------------------------------------------

-- �����˻���

IF OBJECTPROPERTY(OBJECT_ID('backsales'),'IsUserTable') = 1
	DROP TABLE backsales
GO


CREATE TABLE backsales
(
	id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	saleid UNIQUEIDENTIFIER NOT NULL,
	cid UNIQUEIDENTIFIER NOT NULL,
	tosid UNIQUEIDENTIFIER NOT NULL,
	backmoney DECIMAL(18,2) NOT NULL,	-- ����
	backdate DATETIME DEFAULT GETDATE(),
)

GO




-------------------------------------------------------------------------------