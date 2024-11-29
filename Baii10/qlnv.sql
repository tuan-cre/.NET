CREATE TABLE chucvu(
	macv NCHAR(5) PRIMARY KEY,
	tencv NVARCHAR(50),
	hesophucap FLOAT,
);

CREATE TABLE nhanvien(
	manv NCHAR(5) PRIMARY KEY,
	holot NVARCHAR(50),
	tennv NVARCHAR(10),
	phai NVARCHAR(5),
	ngaysinh DATE,
	macv NCHAR(5),
	FOREIGN KEY (macv) REFERENCES chucvu(macv)
);

CREATE TABLE quatrinhluong(
	manv NCHAR(5),
	ngaybd DATE,
	PRIMARY KEY (manv, ngaybd),
	hsluong FLOAT,
	ghichu NVARCHAR(50),
	FOREIGN KEY (manv) REFERENCES nhanvien(manv)
);

INSERT INTO chucvu (macv, tencv, hesophucap) VALUES
	('TP', N'Trưởng phòng', 2.34),
	('PP', N'Phó phòng', 2.12),
	('NV', N'Nhân viên', 1.34);

INSERT INTO nhanvien(manv, holot, tennv, phai, ngaysinh, macv) VALUES
	('NV01', N'Nguyễn Văn', N'A', N'Nam', '1990-12-12', 'TP'),
	('NV02', N'Nguyễn Thị', N'B', N'Nữ', '1995-11-11', 'PP'),
	('NV03', N'Trần Văn', N'C', N'Nam', '1992-10-10', 'NV');

INSERT INTO quatrinhluong(manv, ngaybd, hsluong, ghichu) VALUES
	('NV01', '2018-01-01', 2.34, N'Chuyển từ phòng kế toán'),
	('NV02', '2018-01-01', 2.12, N'Chuyển từ phòng kế toán'),
	('NV03', '2018-01-01', 1.34, N'Chuyển từ phòng kế toán');
