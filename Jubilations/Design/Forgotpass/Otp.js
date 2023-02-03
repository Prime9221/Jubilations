
    let digitValidate = function (ele) {
        console.log(ele.value);
    ele.value = ele.value.replace(/[^0-9]/g, '');
        }

    let tabChange = function (val) {
        let ele = document.querySelectorAll('.otp');
    if (ele[val - 1].value != '') {
        ele[val].focus()
    } else if (ele[val - 1].value == '') {
        ele[val - 2].focus()
    }
        }