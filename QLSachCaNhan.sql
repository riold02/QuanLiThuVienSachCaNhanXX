USE [QLSachCaNhan]
GO
/****** Object:  Table [dbo].[DSMuon]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSMuon](
	[IDMuon] [int] IDENTITY(1,1) NOT NULL,
	[IDSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[SDT] [char](20) NULL,
	[ChoMuon] [bit] NULL,
	[Muon] [bit] NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[DaTra] [bit] NULL,
 CONSTRAINT [PK_DSMuon] PRIMARY KEY CLUSTERED 
(
	[IDMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[IDSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[IDTacGia] [int] NOT NULL,
	[IDTheLoai] [int] NOT NULL,
	[ViTri] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGIa]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGIa](
	[IDTacGia] [int] IDENTITY(1,1) NOT NULL,
	[TacGia] [nvarchar](255) NOT NULL,
	[NamSinh] [date] NULL,
	[QuocTich] [nvarchar](255) NULL,
 CONSTRAINT [PK_TacGIa] PRIMARY KEY CLUSTERED 
(
	[IDTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[IDTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TheLoai] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[IDTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DSMuon] ON 

INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (1, N'S001', N'Cô Gái Đến Từ Hôm Qua', N'Nguyễn Văn A', N'0123456789          ', 1, 0, CAST(N'2024-09-10' AS Date), NULL, N'Hà Nội', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (2, N'S002', N'Những Ngày Xưa Ấy', N'Trần Thị B', N'0123456788          ', 0, 1, CAST(N'2024-09-12' AS Date), NULL, N'TP. Hồ Chí Minh', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (4, N'S004', N'Dế Mèn Phiêu Lưu Ký', N'Phạm Thị D', N'0123456786          ', 1, 0, CAST(N'2024-09-16' AS Date), NULL, N'Cần Thơ', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (5, N'S005', N'Vang Bóng Một Thời', N'Nguyễn Văn E', N'0123456785          ', 0, 1, CAST(N'2024-09-18' AS Date), NULL, N'Huế', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (6, N'S001', N'Cô Gái Đến Từ Hôm Qua', N'Nguyễn Văn A', N'0123456789          ', 1, 0, CAST(N'2024-09-10' AS Date), NULL, N'Hà Nội', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (7, N'S002', N'Những Ngày Xưa Ấy', N'Trần Thị B', N'0123456788          ', 0, 1, CAST(N'2024-09-12' AS Date), NULL, N'TP. Hồ Chí Minh', NULL)
INSERT [dbo].[DSMuon] ([IDMuon], [IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra]) VALUES (9, N'S002', N'Những Ngày Xưa Ấy', N'321', N'321                 ', NULL, NULL, CAST(N'2024-12-03' AS Date), CAST(N'2024-10-09' AS Date), N'321', 0)
SET IDENTITY_INSERT [dbo].[DSMuon] OFF
GO
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S001', N'Cô Gái Đến Từ Hôm Qua', 1, 1, N'Kệ A')
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S002', N'Những Ngày Xưa Ấy', 1, 1, N'Kệ A')
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S003', N'Mắt Biếc', 1, 1, N'Kệ A')
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S004', N'Dế Mèn Phiêu Lưu Ký', 2, 3, N'Kệ B')
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S005', N'Vang Bóng Một Thời', 2, 3, N'Kệ B')
INSERT [dbo].[Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri]) VALUES (N'S006', N'Gọi Cái Tên Có Được Không', 2, 3, N'Kệ B')
GO
SET IDENTITY_INSERT [dbo].[TacGIa] ON 

INSERT [dbo].[TacGIa] ([IDTacGia], [TacGia], [NamSinh], [QuocTich]) VALUES (1, N'Nguyễn Nhật Ánh', CAST(N'1955-05-07' AS Date), N'Việt Nam')
INSERT [dbo].[TacGIa] ([IDTacGia], [TacGia], [NamSinh], [QuocTich]) VALUES (2, N'Xuân Diệu', CAST(N'1921-02-02' AS Date), N'Việt Nam')
INSERT [dbo].[TacGIa] ([IDTacGia], [TacGia], [NamSinh], [QuocTich]) VALUES (3, N'Hữu Loan', CAST(N'1916-03-06' AS Date), N'Việt Nam')
INSERT [dbo].[TacGIa] ([IDTacGia], [TacGia], [NamSinh], [QuocTich]) VALUES (4, N'Tô Hoài', CAST(N'1920-10-27' AS Date), N'Việt Nam')
INSERT [dbo].[TacGIa] ([IDTacGia], [TacGia], [NamSinh], [QuocTich]) VALUES (5, N'Bảo Ninh', CAST(N'1952-03-17' AS Date), N'Việt Nam')
SET IDENTITY_INSERT [dbo].[TacGIa] OFF
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([IDTheLoai], [TheLoai]) VALUES (1, N'Tiểu Thuyết')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TheLoai]) VALUES (2, N'Khoa Học')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TheLoai]) VALUES (3, N'Lịch Sử')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TheLoai]) VALUES (4, N'Giáo Khoa')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TheLoai]) VALUES (5, N'Châm Ngôn')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
ALTER TABLE [dbo].[DSMuon]  WITH CHECK ADD  CONSTRAINT [FK_DSMuon_Sach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[Sach] ([IDSach])
GO
ALTER TABLE [dbo].[DSMuon] CHECK CONSTRAINT [FK_DSMuon_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGIa] FOREIGN KEY([IDTacGia])
REFERENCES [dbo].[TacGIa] ([IDTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGIa]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([IDTheLoai])
REFERENCES [dbo].[TheLoai] ([IDTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSach]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSach]
    @IDSach NVARCHAR(50)
AS
BEGIN
    
    DELETE FROM Sach
    WHERE IDSach = @IDSach;

    RETURN 1; -- Trả về số dòng bị ảnh hưởng (0 nếu không có dòng nào bị xóa)
END;
GO
/****** Object:  StoredProcedure [dbo].[DSMuon_Delete]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DSMuon_Delete]
    @IDMuon INT
AS
BEGIN
    

    -- Xóa bản ghi dựa trên IDMuon
    DELETE FROM DSMuon
    WHERE IDMuon = @IDMuon;

    -- Trả về số dòng bị ảnh hưởng
    RETURN 1; -- 1 nếu xóa thành công, 0 nếu không tìm thấy bản ghi
END;
GO
/****** Object:  StoredProcedure [dbo].[DSMuon_GetAll]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DSMuon_GetAll] 
AS
SELECT * FROM [DSMuon]
GO
/****** Object:  StoredProcedure [dbo].[DSMuon_InsertUpdateDelete]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DSMuon_InsertUpdateDelete]
 @IDMuon INT OUTPUT, -- ID tự tăng
 @IDSach NVARCHAR(50),
 @TenSach NVARCHAR(255),
 @HoTen NVARCHAR(255),
 @SDT CHAR(20),
 @ChoMuon BIT,
 @Muon BIT,
 @NgayMuon DATE,
 @NgayTra DATE,
 @DiaChi NVARCHAR(255),
 @DaTra BIT,
 @Action INT -- 0: Thêm, 1: Sửa, 2: Xóa
AS
IF @Action = 0 -- Thêm
BEGIN
    INSERT INTO [DSMuon] ([IDSach], [TenSach], [HoTen], [SDT], [ChoMuon], [Muon], [NgayMuon], [NgayTra], [DiaChi], [DaTra])
    VALUES (@IDSach, @TenSach, @HoTen, @SDT, @ChoMuon, @Muon, @NgayMuon, @NgayTra, @DiaChi, @DaTra)
    SET @IDMuon = @@IDENTITY
END
ELSE IF @Action = 1 -- Sửa
BEGIN
    UPDATE [DSMuon]
    SET [IDSach] = @IDSach, [TenSach] = @TenSach, [HoTen] = @HoTen, [SDT] = @SDT, [ChoMuon] = @ChoMuon, [Muon] = @Muon,
        [NgayMuon] = @NgayMuon, [NgayTra] = @NgayTra, [DiaChi] = @DiaChi, [DaTra] = @DaTra
    WHERE [IDMuon] = @IDMuon
END
ELSE IF @Action = 2 -- Xóa
BEGIN
    DELETE FROM [DSMuon]
    WHERE [IDMuon] = @IDMuon
END
GO
/****** Object:  StoredProcedure [dbo].[Sach_GetAll]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sach_GetAll] 
AS
SELECT A.IDSach, A.TenSach, B.TacGia AS TacGia, C.TheLoai AS TheLoai, A.ViTri
FROM Sach A
INNER JOIN TacGia B ON A.IDTacGia = B.IDTacGia
INNER JOIN TheLoai C ON A.IDTheLoai = C.IDTheLoai;
GO
/****** Object:  StoredProcedure [dbo].[Sach_InsertUpdateDelete]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sach_InsertUpdateDelete]
 @IDSach NVARCHAR(50),
 @TenSach NVARCHAR(255),
 @IDTacGia INT,
 @IDTheLoai INT,
 @ViTri NVARCHAR(255),
 @Action INT -- 0: Thêm, 1: Sửa, 2: Xóa
AS
IF @Action = 0 -- Thêm
BEGIN
    INSERT INTO [Sach] ([IDSach], [TenSach], [IDTacGia], [IDTheLoai], [ViTri])
    VALUES (@IDSach, @TenSach, @IDTacGia, @IDTheLoai, @ViTri)
END
ELSE IF @Action = 1 -- Sửa
BEGIN
    UPDATE [Sach]
    SET [TenSach] = @TenSach, [IDTacGia] = @IDTacGia, [IDTheLoai] = @IDTheLoai, [ViTri] = @ViTri
    WHERE [IDSach] = @IDSach
END
ELSE IF @Action = 2 -- Xóa
BEGIN
    DELETE FROM [Sach]
    WHERE [IDSach] = @IDSach
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FilterSach]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_FilterSach]
    @TenSach NVARCHAR(255) = NULL,
    @IDTheLoai INT = NULL,
    @IDTacGia INT = NULL,
    @ViTri NVARCHAR(10) = NULL  -- Thêm tham số ViTri
AS
BEGIN
    -- Khởi tạo câu lệnh SQL cơ bản
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = 'SELECT * FROM Sach WHERE 1 = 1'

    -- Kiểm tra IDTheLoai và IDTacGia có tồn tại trong bảng TheLoai và TacGia không
    IF @IDTheLoai IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM TheLoai WHERE IDTheLoai = @IDTheLoai)
        BEGIN
            PRINT 'IDTheLoai không tồn tại trong bảng TheLoai.'
            RETURN
        END
    END

    IF @IDTacGia IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM TacGia WHERE IDTacGia = @IDTacGia)
        BEGIN
            PRINT 'IDTacGia không tồn tại trong bảng TacGia.'
            RETURN
        END
    END

    -- Thêm điều kiện lọc nếu tham số có giá trị
    IF @TenSach IS NOT NULL
        SET @SQL = @SQL + ' AND TenSach LIKE @TenSach'
    
    IF @IDTheLoai IS NOT NULL
        SET @SQL = @SQL + ' AND IDTheLoai = @IDTheLoai'
    
    IF @IDTacGia IS NOT NULL
        SET @SQL = @SQL + ' AND IDTacGia = @IDTacGia'
    
    -- Thêm điều kiện lọc theo ViTri
    IF @ViTri IS NOT NULL
        SET @SQL = @SQL + ' AND ViTri = @ViTri'

    -- Thực thi câu lệnh SQL động
    EXEC sp_executesql @SQL, 
        N'@TenSach NVARCHAR(255), @IDTheLoai INT, @IDTacGia INT, @ViTri NVARCHAR(10)', 
        @TenSach, @IDTheLoai, @IDTacGia, @ViTri
END
GO
/****** Object:  StoredProcedure [dbo].[TacGIa_GetAll]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TacGIa_GetAll] 
AS
SELECT * FROM [TacGIa]
GO
/****** Object:  StoredProcedure [dbo].[TacGIa_InsertUpdateDelete]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TacGIa_InsertUpdateDelete]
 @IDTacGia INT OUTPUT,
 @TacGia NVARCHAR(255),
 @NamSinh DATE,
 @QuocTich NVARCHAR(255),
 @Action INT -- 0: Thêm, 1: Sửa, 2: Xóa
AS
IF @Action = 0 -- Thêm
BEGIN
    INSERT INTO [TacGIa] ([TacGia], [NamSinh], [QuocTich])
    VALUES (@TacGia, @NamSinh, @QuocTich)
    SET @IDTacGia = @@IDENTITY
END
ELSE IF @Action = 1 -- Sửa
BEGIN
    UPDATE [TacGIa]
    SET [TacGia] = @TacGia, [NamSinh] = @NamSinh, [QuocTich] = @QuocTich
    WHERE [IDTacGia] = @IDTacGia
END
ELSE IF @Action = 2 -- Xóa
BEGIN
    DELETE FROM [TacGIa]
    WHERE [IDTacGia] = @IDTacGia
END
GO
/****** Object:  StoredProcedure [dbo].[TheLoai_GetAll]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TheLoai_GetAll] 
AS
SELECT * FROM [TheLoai]
GO
/****** Object:  StoredProcedure [dbo].[TheLoai_InsertUpdateDelete]    Script Date: 12/3/2024 2:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TheLoai_InsertUpdateDelete]
 @IDTheLoai INT OUTPUT,
 @TheLoai NVARCHAR(255),
 @Action INT -- 0: Thêm, 1: Sửa, 2: Xóa
AS
IF @Action = 0 -- Thêm
BEGIN
    INSERT INTO [TheLoai] ([TheLoai])
    VALUES (@TheLoai)
    SET @IDTheLoai = @@IDENTITY
END
ELSE IF @Action = 1 -- Sửa
BEGIN
    UPDATE [TheLoai]
    SET [TheLoai] = @TheLoai
    WHERE [IDTheLoai] = @IDTheLoai
END
ELSE IF @Action = 2 -- Xóa
BEGIN
    DELETE FROM [TheLoai]
    WHERE [IDTheLoai] = @IDTheLoai
END
GO
