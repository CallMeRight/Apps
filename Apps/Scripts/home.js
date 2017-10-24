$(function () {

    var o = {
        showcheck: false,
        url: "/Home/GetTree",
        onnodeclick: function (item) {
            var tabTitle = item.text;
            var url = "../../" + item.value;
            var icon = item.Icon;
            if (!item.hasChildren) {
                addTab(tabTitle, url, icon);
            } else {

                $(this).parent().find("img").trigger("click");
            }
        }
    }
    $.post("/Home/GetTree", { "id": "0" },
        function (data) {
            if (data == "0") {
                window.location = "/Account";
            }
            o.data = data;
            $("#RightTree").treeview(o);
        }, "json");
});