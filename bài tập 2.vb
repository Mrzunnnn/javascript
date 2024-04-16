// câu 1

// console.log("STT|Tên sản phẩm|Giá|Thương hiệu|Số Lượng")

// for(let i = 0; i<products.length;i++){
//     const product = products[i];
//     console.log(`${i+1}|${product.name}|${product.price}|${product.brand}|${product.count}`)
// }



// câu 2

// for(let i = 0; i<products.length;i++){
//     let sum = 0;
//     const product = products[i];
//     console.log(`${i+1}|${product.name}|${sum=product.price*product.count}`)
// }


// câu 3

// for(let i = 0; i<products.length;i++){
//     const product = products[i];
//     if(product.brand==="Apple"){
//         console.log(`${i+1}|${product.name}|${product.price}|${product.brand}|${product.count}`)}
// }


// câu 4

// for(let i = 0; i<products.length;i++){
//     const product = products[i];
//     if(product.price > 20000000){
//     console.log(`${product.name}|${product.price}`)}
// }


// câu 5

// let proProducts = products.filter(product => product.name.toLowerCase().includes("pro"));
// console.log("Các sản phẩm có chữ 'pro' trong tên:", proProducts);

// câu 6

// let newProduct = [
//     {
//         name: "Nokia 1280",
//         price: 350000,
//         brand: "NOKIA",
//         count: 7,
//     }
// ]
// products.push(newProduct);
// console.log(products);


// // câu 7
// products = products.filter(product => product.brand !== "Samsung");
// console.log("Danh sách sản phẩm mới là : ",products);


// câu 8 
// products.sort((a, b) => a.price - b.price);
// console.log(" Câc sản phẩm dược sắp xếp theo giá từ thấp đến cao : ", products)



// Câu 9

// products.sort((a, b) => b.count - a.count);

// console.log( "Các sản phẩm được sắp xếp theo số lượng từ nhiều tới ít : "products);


// câu 10

// let randomProducts = products.slice(0, 2);
// console.log("2 sản phẩm bất kỳ trong giỏ hàng:", randomProducts);