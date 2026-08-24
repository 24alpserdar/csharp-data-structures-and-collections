# 🎲 SortedSet - Set Operations (Küme İşlemleri)

This project demonstrates Advanced Set Theory operations using C# `SortedSet<T>` with randomly generated numbers.

---

### 🇬🇧 Features & Concepts Covered
- **Random Data Generation:** Created 10,000 random integers between 0-1000 using `Random`.
- **Automatic Deduplication & Sorting:** Unique values automatically sorted in ascending order.
- **Set Operations Supported:**
  - `UnionWith(B)`: Combines elements from both sets ($A \cup B$).
  - `IntersectWith(B)`: Finds common elements ($A \cap B$).
  - `ExceptWith(B)`: Removes elements present in Set B ($A \setminus B$).
  - `SymmetricExceptWith(B)`: Finds elements present in either set, but NOT in both ($A \Delta B$).

---

### 🇹🇷 Öne Çıkan Özellikler
- **Rastgele Veri Üretimi:** `Random` sınıfı ile 0-1000 arasında 10.000 adet sayı üretildi.
- **Küme İşlemleri:** `SortedSet` türünün dahili metotları (`UnionWith`, `IntersectWith`, `ExceptWith`, `SymmetricExceptWith`) kullanılarak matematiksel küme operasyonları uygulandı.
