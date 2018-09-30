(function (){
    
    $("#add").click(add);

    var taskInput=$("#task");
    taskInput.keyup(function(event){
        event.preventDefault();

        if(event.keyCode===13){
            add();
        }
    });

    var tasks=[];

    function createButton(){
        var btn=$("<button></button>").text("X");
        btn.attr("class","btn btn-danger mt-2 ml-2");
        btn.click(function(){
            var div=$(this).parent();
            div.css("display","none");
        });
        return btn;
    }

    function add(){
        
        var task=taskInput.val();
        tasks.push(task);
        display();
        $("#task").val("");
    }

    function display(){
        var divelement=$("<div></div>").text(tasks[tasks.length-1]);
        divelement.attr("id","task");

        divelement.append(createButton());

       $("#display").append(divelement);
    }
})();