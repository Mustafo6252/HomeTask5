# HomeTask 5

# 🍽️ OrderController – REST API Hujjat

Ushbu controller `orders` jadvali bilan ishlovchi REST API funksiyalarini o‘z ichiga oladi. Quyida har bir endpoint haqida tushuncha, foydalanish va rasm uchun joy berilgan.

---

## 🔵 POST: Order qo‘shish

**🔗 Endpoint:** `POST /api/order`  
**📝 Sharti:**  
Yangi `order` yozuvini jadvalga qo‘shadi (`id`, `created_at`, `customer_name`, `employee_name` maydonlari bilan).

📎 **Rasm:** _Post qilishdan keyingi natija yoki Postman/Swagger orqali yuborilgan ma’lumot rasm holatida shu yerga joylanadi._

---

## 🟢 GET: Barcha orderlarni olish

**🔗 Endpoint:** `GET /api/order`  
**📝 Sharti:**  
Barcha buyurtmalar (orders) ro‘yxatini qaytaradi.

📎 **Rasm:** _Barcha orderlar ro‘yxati ko‘rsatilgan holat._

---

## 🟡 GET: Orderni ID bo‘yicha olish

**🔗 Endpoint:** `GET /api/order/{id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha bitta orderni qaytaradi. Agar mavjud bo‘lmasa, `404 Not Found` javobi qaytariladi.

📎 **Rasm:** _ID orqali qidirilgan natijani ko‘rsatuvchi rasm joylash uchun._

---

## 🟠 PUT: Orderni tahrirlash

**🔗 Endpoint:** `PUT /api/order`  
**📝 Sharti:**  
Mavjud bo‘lgan orderni yangilaydi (`created_at`, `customer_name`, `employee_name` qiymatlari bilan).  
Agar `id` mavjud bo‘lmasa, `404 Not Found` qaytadi.

📎 **Rasm:** _Update (PUT) dan keyingi muvaffaqiyatli javob rasm holatida._

---

## 🔴 DELETE: Orderni o‘chirish

**🔗 Endpoint:** `DELETE /api/order?id={id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha orderni o‘chiradi. Mavjud bo‘lmasa `404` qaytariladi, bo‘lsa `"Order deleted successfully"` degan xabar qaytariladi.

📎 **Rasm:** _Delete qilish natijasi yoki Postman/Swagger javobi rasm holatida._

---

📌 **Eslatma:**  
Barcha metodlar PostgreSQL bilan Dapper orqali ulanadi va `Restaurant_db` bazasidagi `orders` jadvali bilan ishlaydi.

```csharp
connectionString:
"Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111"


# 📄 OrderDetailsController – REST API Hujjati

Ushbu controller `OrderDetails` jadvali bilan ishlaydi. API orqali buyurtma tafsilotlarini yaratish, ko‘rish, yangilash va o‘chirish mumkin.

---

## 🔵 POST: OrderDetails qo‘shish

**🔗 Endpoint:** `POST /api/orderdetails`  
**📝 Sharti:**  
Yangi `OrderDetails` yozuvini quyidagi maydonlar bilan qo‘shadi:  
- `id`  
- `order_id`  
- `product_name`  
- `unit_price`  
- `quantity`

📎 **Rasm:** _Post qilingan ma’lumotning natijasi ko‘rsatilgan rasm joylashtiriladi._

---

## 🟢 GET: Barcha OrderDetails'ni olish

**🔗 Endpoint:** `GET /api/orderdetails`  
**📝 Sharti:**  
Jadvaldagi barcha `OrderDetails` yozuvlarini ro‘yxat shaklida qaytaradi.

📎 **Rasm:** _Barcha order tafsilotlarini ko‘rsatgan rasm joylashtiriladi._

---

## 🟡 GET: OrderDetails'ni ID bo‘yicha olish

**🔗 Endpoint:** `GET /api/orderdetails/{id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha bitta `OrderDetails` yozuvini qaytaradi. Agar mavjud bo‘lmasa `404` qaytaradi.

📎 **Rasm:** _ID bo‘yicha qidiruv natijasi rasm holatida shu yerga qo‘yiladi._

---

## 🟠 PUT: OrderDetails'ni yangilash

**🔗 Endpoint:** `PUT /api/orderdetails`  
**📝 Sharti:**  
Mavjud `OrderDetails` yozuvini yangilaydi (`order_id`, `product_name`, `unit_price`, `quantity` bilan).  
Agar `id` mavjud bo‘lmasa `404` qaytadi.

📎 **Rasm:** _Update qilish natijasi rasm holatida qo‘yiladi._

---

## 🔴 DELETE: OrderDetails'ni o‘chirish

**🔗 Endpoint:** `DELETE /api/orderdetails?id={id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha `OrderDetails` yozuvini o‘chiradi. Agar mavjud bo‘lmasa `404`, bo‘lsa — muvaffaqiyatli o‘chirilgan yozuvni qaytaradi.

📎 **Rasm:** _Delete javobi yoki holatidan olingan rasmni joylang._

---

📌 **Eslatma:**  
Ushbu controller `Restaurant_db` nomli PostgreSQL bazasida joylashgan `OrderDetails` jadvali bilan ishlaydi.

```csharp
connectionString:
"Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111"


# ➕ AddController – REST API Hujjati

Ushbu controller `OrderDetails` jadvalidagi `id` orqali unga tegishli bo‘lgan `Orders` yozuvini olish uchun ishlatiladi.

---

## 🟢 GET: OrderDetails orqali Order topish

**🔗 Endpoint:** `GET /api/add?id={id}`  
**📝 Sharti:**  
`OrderDetails` jadvalidagi `id` orqali unga tegishli `Orders` yozuvini topadi.  
Bu yerda:
- Dastlab `OrderDetails` dan `order_id` olinadi
- So‘ng `Orders` jadvalidan shu `id` bo‘yicha tegishli buyurtma (order) olinadi.

📎 **Rasm:** _OrderDetails orqali Order topilgan natijani ko‘rsatuvchi rasm joylash uchun._

---

📌 **Ma’lumot:**  
Ushbu controller `Restaurant_db` nomli PostgreSQL bazasi bilan ishlaydi.

```csharp
connectionString:
"Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111"
