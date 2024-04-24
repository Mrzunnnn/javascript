function updateUI(){
    const input =  document.querySelector("input.todo-content");

    input.value = "";

    const list = document.querySelector(".todo-list")
    // đếm số công việc chưa hoàn thành
    
    const items = list.querySelectorAll("li.todo-item")
    let pendingTask = 0;
    items.forEach(function(item) {
        if(!item .classList.contains("completed")){
            pendingTask++;
        }
    });

    if(pendingTask >0){
        document.querySelector(".todo-sumary").style.display = "block";
        document.querySelector(".todo-count").textContent = pendingTask;
    }
    else{
        document.querySelector(".todo-sumary").style.display = "none";
    }
}

function handleUpdateStatus(e){
    const checkbox = e.target;
    const status = e.target.checked;
    const li = checkbox.parentElement;
    if(status){
        li.classList.add("completed")
    }else{
        li.classList.remove("completed")
    }
    updateUI();
}

function createTodo(content){
    // tạo thẻ
    const li = document.createElement("li");
    li.classList.add("todo-item")

    // Tạo checkbox
    const checkbox = document.createElement("input")
    checkbox.type = "checkbox";
    checkbox.addEventListener("change",handleUpdateStatus);

    // Tạo nội dung
    const span = document.createElement("span")
    span.textContent = content;

    // tạo nút edit
    const editButton = document.createElement("button");
    editButton.classList.add("todo-edit");
    editButton.textContent = "Edit";
    editButton.addEventListener("click",handleEditTodo)

    // Tạo nút xoá
    const deleteButton = document.createElement("button")
    deleteButton.classList.add("todo-delete");
    deleteButton.textContent = "Delete";
    deleteButton.addEventListener("click",handleDeleteTodo)

    // Tạo cấu trúc li
    li.append(checkbox,span,editButton,deleteButton);

    // chèn vào list
    document.querySelector(".todo-list").prepend(li)

    updateUI();
}

function handleSubmit(e){
// chặn hành vi mặc định của form (Gửi dữ liệu và reload trình duyệt)
e.preventDefault()


// Lấy dữ liệu từ form
const input = document.querySelector("input.todo-content");
const value = input.value;

// Kiểm tra dữ liệu

if(value.trim()===""){
    return;
}
createTodo(value)
}

function handleDeleteTodo(e){
    const button = e.target;
    const li = button.parentElement;

    if(confirm("Xoá công việc")){

    li.remove()
    updateUI()
}}

function handleEditTodo(e){
    const button = e.target;
    const li = button.parentElement;
    const span = button.previousElementSibling;
    const newContent =  prompt("Thay đổi nội dung công việc", span.textContent);

    span.textContent = newContent;
}


const form = document.querySelector("form.todo-form");

form.addEventListener("submit",handleSubmit)