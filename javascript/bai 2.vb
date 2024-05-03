// Bài 2 javascript


let users = [
    {
      name: "Bùi Công Sơn",
      age: 30,
      isStatus: true,
    },
    {
      name: "Nguyễn Thị Hằng",
      age: 27,
      isStatus: false,
    },
    {
      name: "Phan Văn Dũng",
      age: 20,
      isStatus: false,
    },
  ];

  
// tìm danh sách người trên 25 tuổi

function filterUsersByAgeAndStatus(users) {
    let result = [];
    for (const user of users) {
      if (user.age > 25 && user.isStatus == true) {
        result.push(user);
      }
    }
    return result;
  }
  


//   sắp xếp thứ tự tăng dần
  function sortUsersByAge(users) {
    users.sort((a, b) => a.age - b.age);
    return users;
  }