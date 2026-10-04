# NT106.R12.G5-BaiTap2.2-QuanLyNguoiDung

# Ứng dụng Quản lý Người dùng

## 👥 Thành viên nhóm

| Họ và tên | MSSV |
|-----------|------|
| **Trần Thanh Quân** | `25521508` |
| **Cao Thanh Hiền** | `2552XXXX` |
| **Đào Minh Hiếu** | `2552XXXX` |
| **Hồ Minh Khôi** | `2552XXXX` |
| **Nguyễn Võ Chí Long** | `2552XXXX` |

Ứng dụng Windows Forms được xây dựng bằng **C#**, phục vụ chức năng đăng ký và đăng nhập người dùng trong khuôn khổ môn học **Lập trình mạng căn bản**.

Ứng dụng cung cấp hệ thống quản lý người dùng cơ bản, bao gồm đăng ký tài khoản, đăng nhập, băm mật khẩu, lưu trữ dữ liệu trong cơ sở dữ liệu và xử lý các lỗi phát sinh trong quá trình sử dụng.

> **Lưu ý:** Đề bài gốc sử dụng SQL Server. Trong project này, nhóm sử dụng **MySQL thông qua XAMPP** thay thế cho SQL Server.


## ✨ Chức năng

- Đăng ký tài khoản
- Đăng nhập
- Xác nhận mật khẩu khi đăng ký
- Băm mật khẩu bằng BCrypt
- Kiểm tra tên đăng nhập đã tồn tại
- Kết nối và thao tác với MySQL
- Sử dụng câu lệnh SQL có tham số
- Kiểm tra dữ liệu đầu vào
- Xử lý lỗi đăng nhập
- Xử lý lỗi kết nối cơ sở dữ liệu
- Đăng xuất
- Giao diện Windows Forms


## 🛠️ Công nghệ sử dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET / Windows Forms
- **Cơ sở dữ liệu:** MySQL
- **Môi trường:** XAMPP
- **Băm mật khẩu:** BCrypt
- **IDE:** Visual Studio
- **Quản lý mã nguồn:** Git / GitHub

---

## 🏗️ Cấu trúc ứng dụng

```text
Application
│
├── Login
│   └── Xử lý đăng nhập
│
├── Register
│   └── Xử lý đăng ký tài khoản
│
├── Home
│   └── Thông tin người dùng và đăng xuất
│
├── Database
│   └── Kết nối MySQL và truy vấn dữ liệu
│
└── Authentication
    └── Băm và xác thực mật khẩu
```
## Tại sao sử dụng MySQL + XAMPP?
Theo yêu cầu ban đầu của bài tập, hệ thống được xây dựng với SQL Server. Tuy nhiên, trong project này nhóm lựa chọn MySQL kết hợp với XAMPP.
Việc thay đổi hệ quản trị cơ sở dữ liệu không làm thay đổi bản chất của bài toán. 
Ứng dụng vẫn thực hiện đầy đủ các chức năng cần thiết như lưu trữ tài khoản, truy vấn người dùng, kiểm tra username, đăng ký và đăng nhập.

### MySQL
MySQL là một hệ quản trị cơ sở dữ liệu quan hệ, phù hợp với project vì cung cấp đầy đủ các chức năng cần thiết:
- Lưu trữ dữ liệu người dùng dưới dạng bảng
- Truy vấn dữ liệu bằng SQL
- Hỗ trợ khóa chính (PRIMARY KEY)
- Hỗ trợ ràng buộc duy nhất (UNIQUE)
- Hỗ trợ truy vấn có tham số
- Cho phép ứng dụng C# kết nối và thao tác dữ liệu
Đối với phạm vi của bài tập, MySQL đáp ứng đầy đủ nhu cầu lưu trữ và quản lý dữ liệu người dùng.

### XAMPP
XAMPP được sử dụng làm môi trường chạy MySQL trên máy cục bộ.
Thay vì phải thiết lập một database server riêng, XAMPP cho phép nhóm dễ dàng:
- Khởi động và dừng MySQL
- Chạy database trực tiếp trên máy tính cá nhân
- Quản lý database thông qua phpMyAdmin
- Kiểm thử ứng dụng trong môi trường local
- Dễ dàng thiết lập lại môi trường khi cần

```text
Kiến trúc tổng quát:
┌─────────────────────┐
│   C# Windows Forms  │
│      Application    │
└──────────┬──────────┘
           │
           │ MySQL Connection
           ▼
┌─────────────────────┐
│    MySQL Server     │
└──────────┬──────────┘
           │
           │
┌──────────▼──────────┐
│        XAMPP        │
│  Local Environment  │
└─────────────────────┘
```

MySQL chịu trách nhiệm quản lý và lưu trữ dữ liệu, trong khi XAMPP cung cấp môi trường để chạy MySQL trên máy local.
