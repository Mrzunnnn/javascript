
// Bài 1 javascript

function getStringHasMaxLength(arr) {
    if (arr.length === 0) {
        return [];
    }
    let maxLength = 0;
    for (let i = 0; i < arr.length; i++) {
      if (arr[i].length >= maxLength) {
        maxLength = arr[i].length;
      }
    }
    let result = [];
    for (let i = 0; i < arr.length; i++) {
      if (arr[i].length == maxLength) {
        result.push(arr[i]);
      }
    }
    return result;
  }