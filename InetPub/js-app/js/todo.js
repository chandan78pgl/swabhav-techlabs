(function (){

    document.querySelector("#add").addEventListener("click",add);

    var taskInput=document.getElementById("task");
    taskInput.addEventListener("keyup",function(event){
        event.preventDefault();

        if(event.keyCode===13){
            add();
        }
    });

    var tasks=[];

    function createButton(){
        var btn=document.createElement("button");
        var textNode=document.createTextNode("X");
        btn.appendChild(textNode);
        btn.setAttribute("class","btn btn-danger mt-2 ml-2");
        btn.onclick=function(){
            var div=this.parentElement;
            div.style.display="none";
        }
        return btn;
    }

    function add(){
        var task=taskInput.value;
        tasks.push(task);
        display();
        document.getElementById("task").value="";
    }

    function display(){
        var divelement=document.createElement("div");
        var textnode=document.createTextNode(tasks[tasks.length-1]);
        divelement.appendChild(textnode);
        divelement.setAttribute("id","task");

        divelement.appendChild(createButton());

       document.getElementById("display").appendChild(divelement);
    }
})();

  