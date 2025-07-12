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

### Cấu trúc thư mục
bai_test_1/
├── Controllers/DeviceController.cs
├── Data/AppDbContext.cs
├── Models/Device.cs
├── Views/Device/*.cshtml
├── appsettings.json
└── Program.cs

## Hướng dẫn chạy

### 1. Chạy Docker Compose
### 2. Chạy MySQL container
        docker compose up -d
### 3. Apply migration và chạy web:
        dotnet ef database update
        dotnet run
### Những vấn đề từng gặp
|Vấn đề                               |  Cách xử lý                                                                                |
|-------------------------------------|--------------------------------------------------------------------------------------------|
|dotnet ef không nhận command	      |  Cài tool: dotnet tool install --global dotnet-ef + export PATH="$PATH:$HOME/.dotnet/tools"|
|Conflict giữa EF Core 8 và Pomelo	  |  Đảm bảo chọn đúng version: Pomelo 8.0.3 tương thích EF Core 8.0.13                        |
|Port 3306 bị chiếm khi chạy Docker	  |  Tắt MySQL host: sudo systemctl stop mysql                                                 |

### Ý tưởng mở rộng
    Tìm kiếm thiết bị theo tên
    Phân loại theo trạng thái
    Export danh sách thành Excel/PDF
    Chuyển sang kiến trúc REST API + frontend riêng (React/Vue)

### Tác giả
Mạnh Cao Duy – Ứng viên TTS AI @ NextX
Project test số 1: Quản lý thiết bị đơn giản bằng ASP.NET + MySQL