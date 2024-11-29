CREATE TABLE quequan(
	maqq NCHAR(5) PRIMARY KEY,
	tenqq NVARCHAR(50),
);

CREATE TABLE hocsinh(
	mahs NCHAR(5) PRIMARY KEY,
	holot NVARCHAR(50),
	tenhs NVARCHAR(10),
	phai NVARCHAR(5),
	ngaysinh DATE,
	maqq NCHAR(5),
	FOREIGN KEY (maqq) REFERENCES quequan(maqq)
);

INSERT INTO quequan (maqq, tenqq) VALUES
	('TP', N'Trường Phú'),
	('PP', N'Phú Phong'),
	('NV', N'Ninh Vân');

INSERT INTO hocsinh(mahs, holot, tenhs, phai, ngaysinh, maqq) VALUES
	('HS01', N'Nguyễn Văn', N'A', N'Nam', '1990-12-12', 'TP'),
	('HS02', N'Nguyễn Thị', N'B', N'Nữ', '1995-11-11', 'PP'),
	('HS03', N'Trần Văn', N'C', N'Nam', '1992-10-10', 'NV');