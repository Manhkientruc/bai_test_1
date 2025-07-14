# Mini Device Manager (.NET MVC + MySQL)

## Mô tả dự án
Đây là một ứng dụng web nhỏ được xây dựng bằng ASP.NET Core MVC và sử dụng cơ sở dữ liệu MySQL.  
Ứng dụng mô phỏng chức năng quản lý danh sách các thiết bị trong một tổ chức (ví dụ: phòng máy tính trường học, văn phòng,...), bao gồm:

- Thêm mới thiết bị
- Sửa thông tin thiết bị
- Xoá thiết bị
- Xem danh sách và chi tiết từng thiết bị

## Công nghệ sử dụng

| Thành phần             | Công nghệ               | Lý do chọn                             |
|------------------------|-------------------------|----------------------------------------|
| Backend framework      | ASP.NET Core MVC        | Mạnh, ổn định, tách rõ mô hình MVC     |
| ORM                    | Entity Framework Core 8 | Quản lý DB bằng code-first, dễ migrate |
| CSDL                   | MySQL                   | Phổ biến, tương thích tốt với EF Core  |
| UI                     | Razor Pages             | Tích hợp trong .NET MVC, dễ scaffold   |
| IDE                    | VS Code                 | Gọn nhẹ, phù hợp phát triển đa nền tảng|

## Thiết kế

### Cơ sở dữ liệu
Database `device_db` gồm 1 bảng chính:
- `Devices` (Id, Name, Type, Status)

Sử dụng code-first migration từ EF Core để khởi tạo & cập nhật schema.

## Hướng dẫn chạy

### 0. Cài đặt MySQL 
#### Với Windows (sử dụng XAMPP):
        1. Tải XAMPP tại: https://www.apachefriends.org/index.html
        2. Cài đặt và mở **XAMPP Control Panel**
        3. Start module **MySQL**
        4. Truy cập http://localhost/phpmyadmin để kiểm tra MySQL đã chạy thành công

#### Với Linux (Ubuntu/Debian):
        sudo apt update
        sudo apt install mysql-server
        sudo systemctl start mysql
        sudo systemctl enable mysql
        sudo mysql

### 0.5. Cài đặt .NET
#### Với Windows 
        1. Tải .NET tại: https://dotnet.microsoft.com/en-us/download (tải bản 8.0 tại thời điểm làm dự án)
        2. Cài đặt và vào cmd để kiểm tra bằng 'dotnet --version'
### 1. Tạo database:
#### Truy cập phpMyAdmin (Windows) hoặc dùng terminal (Linux) rồi chạy:
##### Nếu là với Window thì cần khởi động MySQL trong Xampp rồi chuyển vào phần SQL rồi dán đoạn mã dưới đây vào rồi bấm "Go"
        CREATE DATABASE device_db;
        CREATE USER 'devuser'@'localhost' IDENTIFIED BY 'SuperSecure_456!';
        GRANT ALL PRIVILEGES ON device_db.* TO 'devuser'@'localhost';
##### Nếu là với Linux thì cần vào terminal và gõ lệnh 'mysql -u root -p' rồi dán đoạn mã dưới đây vào
        CREATE DATABASE device_db;
        CREATE USER 'devuser'@'localhost' IDENTIFIED BY 'SuperSecure_456!';
        GRANT ALL PRIVILEGES ON device_db.* TO 'devuser'@'localhost';
##### Sau đó thì gõ 'exit' để thoát mysql

### 2. Apply migration và chạy web:
        dotnet tool install --global dotnet-ef
        dotnet ef database update
        dotnet run
#### Có thể thoát IDE (Integrated Development Environment - Môi trường phát triển tích hợp) ra vào lại nếu gặp lỗi khi chạy ' dotnet ef ' và ' dotnet run ' 

### Ý tưởng mở rộng
        Tìm kiếm thiết bị theo tên
        Phân loại theo trạng thái
        Export danh sách thành Excel/PDF
        Chuyển sang kiến trúc REST API + frontend riêng (React/Vue)

### Tác giả
Mạnh Cao Duy – Ứng viên TTS AI @ NextX
Project test số 1: Quản lý thiết bị đơn giản bằng ASP.NET + MySQL
