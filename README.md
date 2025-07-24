# HomeTask 5

# 🍽️ OrderController – REST API Hujjat

Ushbu controller `orders` jadvali bilan ishlovchi REST API funksiyalarini o‘z ichiga oladi. Quyida har bir endpoint haqida tushuncha, foydalanish va rasm uchun joy berilgan.

---

## 🔵 POST: Order qo‘shish

**🔗 Endpoint:** `POST /api/order`  
**📝 Sharti:**  
Yangi `order` yozuvini jadvalga qo‘shadi (`id`, `created_at`, `customer_name`, `employee_name` maydonlari bilan).

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 13 21" src="https://github.com/user-attachments/assets/ad069782-a6c0-463d-a600-130d4c1aa47c" />


## 🟢 GET: Barcha orderlarni olish

**🔗 Endpoint:** `GET /api/order`  
**📝 Sharti:**  
Barcha buyurtmalar (orders) ro‘yxatini qaytaradi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 13 37" src="https://github.com/user-attachments/assets/c28a2b9f-ef0f-4e59-82c3-57d55ba04c9b" />


## 🟡 GET: Orderni ID bo‘yicha olish

**🔗 Endpoint:** `GET /api/order/{id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha bitta orderni qaytaradi. Agar mavjud bo‘lmasa, `404 Not Found` javobi qaytariladi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 14 01" src="https://github.com/user-attachments/assets/f1785773-2e95-42c2-9d32-cd76d4003bc5" />


## 🟠 PUT: Orderni tahrirlash

**🔗 Endpoint:** `PUT /api/order`  
**📝 Sharti:**  
Mavjud bo‘lgan orderni yangilaydi (`created_at`, `customer_name`, `employee_name` qiymatlari bilan).  
Agar `id` mavjud bo‘lmasa, `404 Not Found` qaytadi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 16 02" src="https://github.com/user-attachments/assets/48648dbf-af5f-41f7-b14e-b53a1f28a6df" />


## 🔴 DELETE: Orderni o‘chirish

**🔗 Endpoint:** `DELETE /api/order?id={id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha orderni o‘chiradi. Mavjud bo‘lmasa `404` qaytariladi, bo‘lsa `"Order deleted successfully"` degan xabar qaytariladi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 16 27" src="https://github.com/user-attachments/assets/b3b1cf98-ddca-4c90-8c99-94ed14efaa8f" />


📌 **Eslatma:**  
Barcha metodlar PostgreSQL bilan Dapper orqali ulanadi va `Restaurant_db` bazasidagi `orders` jadvali bilan ishlaydi.




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

📎 **Rasm:**

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 45 23" src="https://github.com/user-attachments/assets/4ca901a4-c742-47da-8fa9-5cf2545b0358" />



## 🟢 GET: Barcha OrderDetails'ni olish

**🔗 Endpoint:** `GET /api/orderdetails`  
**📝 Sharti:**  
Jadvaldagi barcha `OrderDetails` yozuvlarini ro‘yxat shaklida qaytaradi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 45 34" src="https://github.com/user-attachments/assets/6be3ca40-0d46-4b69-af9c-54cf7260f173" />


## 🟡 GET: OrderDetails'ni ID bo‘yicha olish

**🔗 Endpoint:** `GET /api/orderdetails/{id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha bitta `OrderDetails` yozuvini qaytaradi. Agar mavjud bo‘lmasa `404` qaytaradi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 45 54" src="https://github.com/user-attachments/assets/acccb699-95b4-40bc-8c5f-2a99f65cc52b" />

## 🟠 PUT: OrderDetails'ni yangilash

**🔗 Endpoint:** `PUT /api/orderdetails`  
**📝 Sharti:**  
Mavjud `OrderDetails` yozuvini yangilaydi (`order_id`, `product_name`, `unit_price`, `quantity` bilan).  
Agar `id` mavjud bo‘lmasa `404` qaytadi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 46 49" src="https://github.com/user-attachments/assets/ef95c4ae-fae8-4a92-9b18-33a46e81219d" />


## 🔴 DELETE: OrderDetails'ni o‘chirish

**🔗 Endpoint:** `DELETE /api/orderdetails?id={id}`  
**📝 Sharti:**  
Berilgan `id` bo‘yicha `OrderDetails` yozuvini o‘chiradi. Agar mavjud bo‘lmasa `404`, bo‘lsa — muvaffaqiyatli o‘chirilgan yozuvni qaytaradi.

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 10 47 02" src="https://github.com/user-attachments/assets/ab2dab07-139f-4859-aada-948ccd0e3bc1" />


📌 **Eslatma:**  
Ushbu controller `Restaurant_db` nomli PostgreSQL bazasida joylashgan `OrderDetails` jadvali bilan ishlaydi.



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

📎 **Rasm:** 

<img width="600" height="900" alt="Screenshot 2025-07-24 at 11 57 11" src="https://github.com/user-attachments/assets/89254d11-bc4a-4eab-9fbf-d24c45711c5a" />


📌 **Ma’lumot:**  
Ushbu controller `Restaurant_db` nomli PostgreSQL bazasi bilan ishlaydi.


