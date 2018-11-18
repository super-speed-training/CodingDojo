# Homework 09
จงเขียนโปรแกรม PoS โดยโปรแกรมจะให้ทำการป้อนรหัสสินค้าที่ต้องการซื้อลงในตระกร้า แล้วโปรแกรมจะทำการคำนวณราคาที่ต้องจ่ายทั้งหมดให้

## เงื่อนไข
* ข้อมูลรายการสินค้าทั้งหมดอยู่ในไฟล์ที่ชื่อว่า `product.csv`
* การป้อนรหัสสินค้า 1 ครั้ง โปรแกรมจะเพิ่มจำนวนสินค้าที่ต้องการจะซื้อทีละ 1 ชิ้น
* กรณีที่ไม่เจอสินค้ารหัสนั้นๆโปรแกรมจะแจ้งเตือนข้อผิดพลาด

## product.csv
```
SKU,Name,Price
p01,iPad Pro 11-inch,23900
p02,Apple Watch Series 4,14400
p03,MacBook Pro with Touch Bar,47900
p04,Apple TV 4K,8500
p05,iPhone XS,39900
p06,iPhone XS Max,43900
p07,iPhone XR,29900
p08,MacBook Air 13-inch,42900
p09,Mac Mini 2018,27900
```

## ตัวอย่าง
ตัวอย่างด้านล่างนี้เป็นการทำงานทีละขั้นตอนตามลำดับ  
> `<<รอรับ input>>` เป็นการรอรับข้อมูลจาก keyboard
```
Product in your cart are
none
---
Total amount: 0 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p01`

```
Product in your cart are
iPad Pro 11-inch        23,900.00
---
Total amount: 23,900.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p02`

```
Product in your cart are
iPad Pro 11-inch        23,900.00
Apple Watch Series 4    14,400.00
---
Total amount: 38,300.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p02`

```
Product in your cart are
iPad Pro 11-inch        23,900.00
Apple Watch Series 4    14,400.00
Apple Watch Series 4    14,400.00
---
Total amount: 52,700.00 baht
Please input a product key: <<รอรับ input>>
```

> Notes:  
Assume the data is input by console.

## Interface(s)
```
public interface IHomework09
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
}

public interface IProduct
{
    string SKU { get;set; }
    string Name { get;set; }
    double Price { get;set; }
}
```
