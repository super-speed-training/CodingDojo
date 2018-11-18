# Homework 10
ต่อจาก [Homework 09](HomeWork09.md) นอกจากโปรแกรมจะสามารถคำนวณราคาสินค้าได้แล้ว ลูกค้ายังต้องการให้เพิ่มความสามารถของโปรแกรมดังนี้
1. สามารถเซฟและโหลดสถานะของตระกร้าสินค้าล่าสุดได้
1. การนำสินค้าเข้าตระกร้าสามารถระบุจำนวนที่ต้องการได้

## เงื่อนไข
* เมื่อเปิดโปรแกรมขึ้นมา โปรแกรมจะทำการโหลดสถานะตระกร้าล่าสุดที่เคยเซฟไว้ขึ้นมา
* การระบุจำนวนสินค้าจะใส่ `,` แล้วตามด้วย `จำนวนสินค้า`
* กรณีที่ไม่ระบุจำนวนหรือใส่จำนวนเป็นค่าที่ไม่ถูกต้อง จะถือว่าเพิ่มสินค้าทีละ 1 ชิ้น
* ถ้าปิดโปรแกรมโดยไม่เซฟ ระบบจะไม่ทำการเซฟสถานะล่าสุดไว้
* เมื่อต้องการเซฟสถานะล่าสุดให้พิมพ์คำว่า `save`
* Input ของโปรแกรมนี้เป็น `case sensitive`
* ไฟล์สถานะล่าสุดของตระกร้าจะต้องเป็นไฟล์ `cart.json` และภายในจะต้องเป็น `JSON format` เท่านั้น

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
Products in your cart are
none
---
Total amount: 0.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p01`

```
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
---
Total amount: 23,900.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการพิมพ์คำว่า `save` แล้วกด enter

```
Current state had been saved!
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
---
Total amount: 23,900.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p02`

```
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
2.Apple Watch Series 4    (1) 14,400.00
---
Total amount: 38,300.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการปิดโปรแกรม แล้วเปิดขึ้นมาใหม่

```
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
---
Total amount: 23,900.00 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p02,5`

```
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
2.Apple Watch Series 4    (5) 14,400.00
---
Total amount: 95,900 baht
Please input a product key: <<รอรับ input>>
```

ทำการใส่รหัสสินค้า `p06,helloworld`
```
Products in your cart are
1.iPad Pro 11-inch        (1) 23,900.00
2.Apple Watch Series 4    (5) 14,400.00
3.iPhone XS Max           (1) 43,900.00
---
Total amount: 139,800 baht
Please input a product key: <<รอรับ input>>
```

> Notes:  
Assume the data is input by console.

## Interface(s)
```
public interface IHomework10
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
    void SaveCurrentState();
    string LoadSavedCart();
}

public interface IProduct
{
    string SKU { get;set; }
    string Name { get;set; }
    double Price { get;set; }
}
```
