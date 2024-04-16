// Câu 1


// function calculateFactorial(number) {

//     if (number === 0 || number === 1) {
//         return 1;
//     } else {

//         let factorial = 1;
//         for (let i = 2; i <= number; i++) {
//             factorial *= i;
//         }
//         return factorial;
//     }
// }


// console.log(calculateFactorial(6)); 


// Câu 2

// function reverseString(str){
//     let arr = str.split("");
//     let reverse = arr.reverse();
//     let newArr = reverse.join('');
//     return newArr;
// }

// console.log(reverseString("hello"));


// câu 3

// function translate(countryCode) {
//     let message;
//     switch (countryCode) {
//         case 'VN':
//             message = 'Xin chào';
//             break;

//         case 'EN':
//             message = 'Hello';
//             break;
//         case 'CN':
//             message = 'Nihao';
//             break;
//         case 'JP':
//             message = 'Konichiwa';
//             break;        
//         default:
//             message = 'Không tìm thấy mã quốc gia.';
//     }


//     return message;
// }


// console.log(translate('CN'));


// câu 4

// function subString(str) {

//     if (str.length > 15) {
//         let newStr = str.slice(0, 10);
//         newStr += '...';
//         return newStr;
//     } else {
//         return str;
//     }
// }

// console.log(subString("xinchaocacbandenvoiTechmaster")); 