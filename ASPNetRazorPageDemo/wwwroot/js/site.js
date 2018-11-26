// Write your Javascript code.

//var gSite = "http://192.168.0.111" + ":4000"
//var gSite = "http://172.20.10.5" + ":4000"
//var gSite = "http://192.168.0.104" + ":4000"
var gSite = "http://192.168.0.28" + ":4000"
var gWebSite = "192.168.0.28"

var finished = '<span class="label label-primary">Finished</span>'
var matched = '<span class="label label-success">Matched</span>'
var pending = '<span class="label label-info">Pending</span>'
var paymenterror = '<span class="label label-warning">PaymentError</span>'
var cancelled = '<span class="label label-danger">Cancelled</span>'
var fontRed = ' style="color:red"'
var fontDefault = ' style=""'
var PaidInterestDate="";


function formatTXStatus(status) {
        var status_label="";

        if (status=="Pending") {
            status_label=pending
        }
        if (status=="Matched") {
            status_label=matched
        }
        if (status=="Cancelled") {
            status_label=cancelled
        }
        if (status=="Finished") {
            status_label=finished
        }

         return status_label;
}

function formatApproveFlag(flag) {
        var flag_label="";

        if (flag=="0") {
            flag_label=" 0 - 成功(預設)"
        }
        if (flag=="1") {
            flag_label=" 1 - 等待回應"
        }
        if (flag=="2") {
            flag_label=" 2 - 款不足"
        }
        if (flag=="3") {
            flag_label=" 3 - 系統錯誤"
        }
        if (flag=="5") {
            flag_label=" 5 - 自動檢核"
        }


         return flag_label;
}

function numberWithCommas(number) {
         var parts = number.toString().split(".");
         parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
         return parts.join(".");
}


