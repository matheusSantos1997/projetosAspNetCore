(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["styles"],{

/***/ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./node_modules/bootstrap/dist/css/bootstrap.min.css":
/*!****************************************************************************************************************************************************************************************************!*\
  !*** ./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src??embedded!./node_modules/bootstrap/dist/css/bootstrap.min.css ***!
  \****************************************************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {


/***/ }),

/***/ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css":
/*!**********************************************************************************************************************************************************************************************************!*\
  !*** ./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src??embedded!./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css ***!
  \**********************************************************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = [[module.i, "/* .bs-datepicker */\n.bs-datepicker {\n  display: flex;\n  align-items: stretch;\n  flex-flow: row wrap;\n  background: #fff;\n  box-shadow: 0 0 10px 0 #aaa;\n  position: relative;\n  z-index: 1;\n  /* button */\n  /* .bs-datepicker-head */\n  /* .bs-datepicker-body */\n  /* .current-timedate */\n  /* .bs-datepicker-multiple */\n  /* .bs-datepicker-btns */\n  /*.bs-datepicker-custom-range */\n  /* .bs-datepicker-predefined-btns */\n  /* .bs-datepicker-buttons */ }\n.bs-datepicker:after {\n    clear: both;\n    content: '';\n    display: block; }\n.bs-datepicker bs-day-picker {\n    float: left; }\n.bs-datepicker button:hover,\n  .bs-datepicker button:focus,\n  .bs-datepicker button:active,\n  .bs-datepicker input:hover,\n  .bs-datepicker input:focus,\n  .bs-datepicker input:active,\n  .bs-datepicker-btns button:hover,\n  .bs-datepicker-btns button:focus,\n  .bs-datepicker-btns button:active,\n  .bs-datepicker-predefined-btns button:active,\n  .bs-datepicker-predefined-btns button:focus {\n    outline: none; }\n.bs-datepicker-head {\n    min-width: 270px;\n    height: 50px;\n    padding: 10px;\n    border-radius: 3px 3px 0 0;\n    text-align: justify;\n    /* .bs-datepicker-head button */ }\n.bs-datepicker-head:after {\n      content: \"\";\n      display: inline-block;\n      vertical-align: top;\n      width: 100%; }\n.bs-datepicker-head button {\n      display: inline-block;\n      vertical-align: top;\n      padding: 0;\n      height: 30px;\n      line-height: 30px;\n      border: 0;\n      background: transparent;\n      text-align: center;\n      cursor: pointer;\n      color: #fff;\n      transition: 0.3s; }\n.bs-datepicker-head button[disabled], .bs-datepicker-head button[disabled]:hover, .bs-datepicker-head button[disabled]:active {\n        background: rgba(221, 221, 221, 0.3);\n        color: #f5f5f5;\n        cursor: not-allowed; }\n.bs-datepicker-head button.next, .bs-datepicker-head button.previous {\n        border-radius: 50%;\n        width: 30px;\n        height: 30px; }\n.bs-datepicker-head button.next span, .bs-datepicker-head button.previous span {\n          font-size: 28px;\n          line-height: 1;\n          display: inline-block;\n          position: relative;\n          height: 100%;\n          width: 100%;\n          border-radius: 50%; }\n.bs-datepicker-head button.current {\n        border-radius: 15px;\n        max-width: 155px;\n        padding: 0 13px; }\n.bs-datepicker-head button:hover {\n    background-color: rgba(0, 0, 0, 0.1); }\n.bs-datepicker-head button:active {\n    background-color: rgba(0, 0, 0, 0.2); }\n.bs-datepicker-body {\n    padding: 10px;\n    border-radius: 0 0 3px 3px;\n    min-height: 232px;\n    min-width: 278px;\n    border: 1px solid #e9edf0;\n    /* .bs-datepicker-body table */ }\n.bs-datepicker-body .days.weeks {\n      position: relative;\n      z-index: 1; }\n.bs-datepicker-body table {\n      width: 100%;\n      border-collapse: separate;\n      border-spacing: 0;\n      /* .bs-datepicker-body table.days */\n      /* .bs-datepicker-body table.weeks */ }\n.bs-datepicker-body table th {\n        font-size: 13px;\n        color: #9aaec1;\n        font-weight: 400;\n        text-align: center; }\n.bs-datepicker-body table td {\n        color: #54708b;\n        text-align: center;\n        position: relative;\n        padding: 0; }\n.bs-datepicker-body table td span {\n          display: block;\n          margin: 0 auto;\n          font-size: 13px;\n          border-radius: 50%;\n          /*z-index: 1;*/\n          -moz-user-select: none;\n          -webkit-user-select: none;\n          -ms-user-select: none; }\n.bs-datepicker-body table td:not(.disabled):not(.week) span:not(.disabled):not(.is-other-month) {\n          cursor: pointer; }\n.bs-datepicker-body table td.is-highlighted:not(.disabled):not(.selected) span,\n        .bs-datepicker-body table td span.is-highlighted:not(.disabled):not(.selected) {\n          background-color: #e9edf0;\n          transition: 0s; }\n.bs-datepicker-body table td.is-active-other-month:not(.disabled):not(.selected) span,\n        .bs-datepicker-body table td span.is-active-other-month:not(.disabled):not(.selected) {\n          background-color: #e9edf0;\n          transition: 0s;\n          cursor: pointer; }\n.bs-datepicker-body table td span.disabled,\n        .bs-datepicker-body table td.disabled span {\n          color: #9aaec1; }\n.bs-datepicker-body table td span.selected,\n        .bs-datepicker-body table td.selected span {\n          color: #fff; }\n.bs-datepicker-body table td span.is-other-month,\n        .bs-datepicker-body table td.is-other-month span {\n          color: rgba(0, 0, 0, 0.25); }\n.bs-datepicker-body table td.active {\n          position: relative; }\n.bs-datepicker-body table td.active.select-start:before {\n            left: 35%; }\n.bs-datepicker-body table td.active.select-end:before {\n            left: -85%; }\n.bs-datepicker-body table td span.active.select-start:after,\n        .bs-datepicker-body table td span.active.select-end:after,\n        .bs-datepicker-body table td.active.select-start span:after,\n        .bs-datepicker-body table td.active.select-end span:after {\n          content: \"\";\n          display: block;\n          position: absolute;\n          z-index: -1;\n          width: 100%;\n          height: 100%;\n          transition: 0.3s;\n          top: 0;\n          border-radius: 50%; }\n.bs-datepicker-body table td:before,\n        .bs-datepicker-body table td span:before {\n          content: \"\";\n          display: block;\n          position: absolute;\n          z-index: -1;\n          top: 6px;\n          bottom: 6px;\n          left: -3px;\n          right: -2px;\n          box-sizing: content-box;\n          background: transparent; }\n.bs-datepicker-body table td.active.select-start + td.active:before {\n          left: -20%; }\n.bs-datepicker-body table td:last-child.active:before {\n          border-radius: 0 3px 3px 0;\n          width: 125%;\n          left: -25%; }\n.bs-datepicker-body table td span[class*=\"select-\"],\n        .bs-datepicker-body table td[class*=\"select-\"] span {\n          border-radius: 50%;\n          color: #fff; }\n.bs-datepicker-body table.days td.active:not(.select-start):before, .bs-datepicker-body table.days td.in-range:not(.select-start):before,\n      .bs-datepicker-body table.days span.active:not(.select-start):before,\n      .bs-datepicker-body table.days span.in-range:not(.select-start):before {\n        background: #e9edf0; }\n.bs-datepicker-body table.days span {\n        width: 32px;\n        height: 32px;\n        line-height: 32px; }\n.bs-datepicker-body table.days span.select-start {\n          z-index: 2; }\n.bs-datepicker-body table.days span.is-highlighted.in-range:before {\n          right: 3px;\n          left: 0; }\n.bs-datepicker-body table.days span.in-range.select-end:before {\n          right: 4px;\n          left: 0; }\n.bs-datepicker-body table.days td.select-start + td.select-end:before,\n      .bs-datepicker-body table.days td.select-start + td.is-highlighted:before,\n      .bs-datepicker-body table.days td.active + td.is-highlighted:before,\n      .bs-datepicker-body table.days td.active + td.select-end:before,\n      .bs-datepicker-body table.days td.in-range + td.is-highlighted:before,\n      .bs-datepicker-body table.days td.in-range + td.select-end:before {\n        background: #e9edf0;\n        width: 100%; }\n.bs-datepicker-body table.weeks tr td:nth-child(2).active:before {\n        border-radius: 3px 0 0 3px;\n        left: 0;\n        width: 100%; }\n.bs-datepicker-body table:not(.weeks) tr td:first-child:before {\n        border-radius: 3px 0 0 3px; }\n.bs-datepicker-body table.years td span {\n        width: 46px;\n        height: 46px;\n        line-height: 45px;\n        margin: 0 auto; }\n.bs-datepicker-body table.years tr:not(:last-child) td span {\n        margin-bottom: 8px; }\n.bs-datepicker-body table.months td {\n        height: 52px; }\n.bs-datepicker-body table.months td span {\n          padding: 6px;\n          border-radius: 15px; }\n.bs-datepicker .current-timedate {\n    color: #54708b;\n    font-size: 15px;\n    text-align: center;\n    height: 30px;\n    line-height: 30px;\n    border-radius: 20px;\n    border: 1px solid #e9edf0;\n    margin-bottom: 10px;\n    cursor: pointer;\n    text-transform: uppercase;\n    -moz-user-select: none;\n    -webkit-user-select: none;\n    -ms-user-select: none; }\n.bs-datepicker .current-timedate span:not(:empty):before {\n      content: \"\";\n      width: 15px;\n      height: 16px;\n      display: inline-block;\n      margin-right: 4px;\n      vertical-align: text-bottom;\n      background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA8AAAAQCAYAAADJViUEAAABMklEQVQoU9VTwW3CQBCcOUgBtEBKSAukAnBKME+wFCAlYIhk8sQlxFABtJAScAsuAPBEewYcxCP8ouxrPDsza61uiVN1o6RNHD4htSCmq49RfO71BvMJqBBkITRf1kmUW49nQRC9h1I5AZlBClaL8aP1fKgOOxCx8aSLs+Q19eZuNO8QmPqJRtDFguy7OAcDbJPs+/BKVPDIPrvD2ZJgWAmVe7O0rI0Vqs1seyWUXpuJoppYCa5L+U++NpNPkr5OE2oMdARsb3gykJT5ydZcL8Z9Ww60nxg2LhjON9li9OwXZzo+xLbp3nC2s9CL2RrueGyVrgwNm8HpsCzZ9EEW6kqXlo1GQe03FzP/7W8Hl0dBtu7Bf7zt6mIwvX1RvzDCm7+q3mAW0Dl/GPdUCeXrZLT9BrDrGkm4qlPvAAAAAElFTkSuQmCC); }\n.bs-datepicker-multiple {\n    border-radius: 4px 0 0 4px; }\n.bs-datepicker-multiple + .bs-datepicker-multiple {\n      margin-left: 10px; }\n.bs-datepicker-multiple .bs-datepicker {\n      box-shadow: none;\n      position: relative; }\n.bs-datepicker-multiple .bs-datepicker:not(:last-child) {\n        padding-right: 10px; }\n.bs-datepicker-multiple .bs-datepicker + .bs-datepicker:after {\n        content: \"\";\n        display: block;\n        width: 14px;\n        height: 10px;\n        background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA8AAAAKCAYAAABrGwT5AAAA1ElEQVQoU42RsQrCUAxF77VuDu7O4oMWW//BURBBpZvgKk4uIrjoqKOTf+DopIO4uYggtFTfw3+pkQqCW1/G5J7kJiFy4m5MxUlxAzgIPHX+lzMPzupRYlYgxiR7vqsOP8YKzsTx0yxFMCUZ+q7aZzlr+OvgoWcAFyAHgat2jLWu48252DdqAihDJGSSJNUUxYmQjs3+hPQBlAh2rG2LCOPnaw3IiGDX99TRCs7ASJsNhUOA7d/LcuHvRG22FIZvsNXw1MX6VZExCilOQKEfeLXr/10+aC9Ho7arh7oAAAAASUVORK5CYII=);\n        position: absolute;\n        top: 25px;\n        left: -8px; }\n.bs-datepicker-multiple .bs-datepicker .left {\n        float: left; }\n.bs-datepicker-multiple .bs-datepicker .right {\n        float: right; }\n.bs-datepicker-container {\n    padding: 15px; }\n.bs-datepicker .bs-media-container {\n    display: flex; }\n@media (max-width: 768px) {\n      .bs-datepicker .bs-media-container {\n        flex-direction: column; } }\n.bs-datepicker-custom-range {\n    padding: 15px;\n    background: #eee; }\n.bs-datepicker-predefined-btns button {\n    width: 100%;\n    display: block;\n    height: 30px;\n    background-color: #9aaec1;\n    border-radius: 4px;\n    color: #fff;\n    border: 0;\n    margin-bottom: 10px;\n    padding: 0 18px;\n    text-align: left;\n    transition: 0.3s; }\n.bs-datepicker-predefined-btns button:hover {\n      background-color: #54708b; }\n.bs-datepicker-buttons {\n    display: flex;\n    flex-flow: row wrap;\n    justify-content: flex-end;\n    padding-top: 10px;\n    border-top: 1px solid #e9edf0; }\n.bs-datepicker-buttons .btn-default {\n      margin-left: 10px; }\n.bs-datepicker-buttons .btn-today-wrapper {\n      display: flex;\n      flex-flow: row wrap; }\n.bs-datepicker-buttons .clear-right,\n    .bs-datepicker-buttons .today-right {\n      flex-grow: 0; }\n.bs-datepicker-buttons .clear-left,\n    .bs-datepicker-buttons .today-left {\n      flex-grow: 1; }\n.bs-datepicker-buttons .clear-center,\n    .bs-datepicker-buttons .today-center {\n      flex-grow: 0.5; }\n/* .bs-timepicker */\n.bs-timepicker-container {\n  padding: 10px 0; }\n.bs-timepicker-label {\n  color: #54708b;\n  margin-bottom: 10px; }\n.bs-timepicker-controls {\n  display: inline-block;\n  vertical-align: top;\n  margin-right: 10px; }\n.bs-timepicker-controls button {\n    width: 20px;\n    height: 20px;\n    border-radius: 50%;\n    border: 0;\n    background-color: #e9edf0;\n    color: #54708b;\n    font-size: 16px;\n    font-weight: 700;\n    vertical-align: middle;\n    line-height: 0;\n    padding: 0;\n    transition: 0.3s; }\n.bs-timepicker-controls button:hover {\n      background-color: #d5dadd; }\n.bs-timepicker-controls input {\n    width: 35px;\n    height: 25px;\n    border-radius: 13px;\n    text-align: center;\n    border: 1px solid #e9edf0; }\n.bs-timepicker .switch-time-format {\n  text-transform: uppercase;\n  min-width: 54px;\n  height: 25px;\n  border-radius: 20px;\n  border: 1px solid #e9edf0;\n  background: #fff;\n  color: #54708b;\n  font-size: 13px; }\n.bs-timepicker .switch-time-format img {\n    vertical-align: initial;\n    margin-left: 4px; }\nbs-datepicker-container,\nbs-daterangepicker-container {\n  z-index: 1080; }\n/* screen size < 1024px */\n@media (max-width: 768px) {\n  .bs-datepicker-multiple {\n    display: flex; }\n    .bs-datepicker-multiple + .bs-datepicker-multiple {\n      margin-top: 10px;\n      margin-left: 0; } }\n/* theming */\n.theme-default .bs-datepicker-head {\n  background-color: #777; }\n.theme-default .btn-today-wrapper .btn-success, .theme-default .btn-clear-wrapper .btn-success {\n  background-color: #777;\n  border-color: #777; }\n.theme-default .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-default .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-default .btn-today-wrapper .btn-success:focus, .theme-default .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-default .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-default .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #616161;\n  border-color: #616161; }\n.theme-default .btn-today-wrapper .btn-success:hover, .theme-default .btn-clear-wrapper .btn-success:hover {\n  background-color: #6F6E6E;\n  border-color: #6F6E6E; }\n.theme-default .bs-datepicker-predefined-btns button.selected {\n  background-color: #777; }\n.theme-default .bs-datepicker-body table td span.selected,\n.theme-default .bs-datepicker-body table td.selected span,\n.theme-default .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-default .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #777; }\n.theme-default .bs-datepicker-body table td.week span {\n  color: #777; }\n.theme-default .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #777;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n.theme-green .bs-datepicker-head {\n  background-color: #5cb85c; }\n.theme-green .btn-today-wrapper .btn-success, .theme-green .btn-clear-wrapper .btn-success {\n  background-color: #5cb85c;\n  border-color: #5cb85c; }\n.theme-green .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-green .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-green .btn-today-wrapper .btn-success:focus, .theme-green .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-green .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-green .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #1e7e34;\n  border-color: #1e7e34; }\n.theme-green .btn-today-wrapper .btn-success:hover, .theme-green .btn-clear-wrapper .btn-success:hover {\n  background-color: #218838;\n  border-color: #218838; }\n.theme-green .bs-datepicker-predefined-btns button.selected {\n  background-color: #5cb85c; }\n.theme-green .bs-datepicker-body table td span.selected,\n.theme-green .bs-datepicker-body table td.selected span,\n.theme-green .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-green .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #5cb85c; }\n.theme-green .bs-datepicker-body table td.week span {\n  color: #5cb85c; }\n.theme-green .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #5cb85c;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n.theme-blue .bs-datepicker-head {\n  background-color: #5bc0de; }\n.theme-blue .btn-today-wrapper .btn-success, .theme-blue .btn-clear-wrapper .btn-success {\n  background-color: #5bc0de;\n  border-color: #5bc0de; }\n.theme-blue .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-blue .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-blue .btn-today-wrapper .btn-success:focus, .theme-blue .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-blue .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-blue .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #2AA8CD;\n  border-color: #2AA8CD; }\n.theme-blue .btn-today-wrapper .btn-success:hover, .theme-blue .btn-clear-wrapper .btn-success:hover {\n  background-color: #3AB3D7;\n  border-color: #3AB3D7; }\n.theme-blue .bs-datepicker-predefined-btns button.selected {\n  background-color: #5bc0de; }\n.theme-blue .bs-datepicker-body table td span.selected,\n.theme-blue .bs-datepicker-body table td.selected span,\n.theme-blue .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-blue .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #5bc0de; }\n.theme-blue .bs-datepicker-body table td.week span {\n  color: #5bc0de; }\n.theme-blue .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #5bc0de;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n.theme-dark-blue .bs-datepicker-head {\n  background-color: #337ab7; }\n.theme-dark-blue .btn-today-wrapper .btn-success, .theme-dark-blue .btn-clear-wrapper .btn-success {\n  background-color: #337ab7;\n  border-color: #337ab7; }\n.theme-dark-blue .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-dark-blue .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-dark-blue .btn-today-wrapper .btn-success:focus, .theme-dark-blue .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-dark-blue .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-dark-blue .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #266498;\n  border-color: #266498; }\n.theme-dark-blue .btn-today-wrapper .btn-success:hover, .theme-dark-blue .btn-clear-wrapper .btn-success:hover {\n  background-color: #2C6FA9;\n  border-color: #2C6FA9; }\n.theme-dark-blue .bs-datepicker-predefined-btns button.selected {\n  background-color: #337ab7; }\n.theme-dark-blue .bs-datepicker-body table td span.selected,\n.theme-dark-blue .bs-datepicker-body table td.selected span,\n.theme-dark-blue .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-dark-blue .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #337ab7; }\n.theme-dark-blue .bs-datepicker-body table td.week span {\n  color: #337ab7; }\n.theme-dark-blue .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #337ab7;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n.theme-red .bs-datepicker-head {\n  background-color: #d9534f; }\n.theme-red .btn-today-wrapper .btn-success, .theme-red .btn-clear-wrapper .btn-success {\n  background-color: #d9534f;\n  border-color: #d9534f; }\n.theme-red .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-red .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-red .btn-today-wrapper .btn-success:focus, .theme-red .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-red .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-red .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #D23531;\n  border-color: #D23531; }\n.theme-red .btn-today-wrapper .btn-success:hover, .theme-red .btn-clear-wrapper .btn-success:hover {\n  background-color: #E33732;\n  border-color: #E33732; }\n.theme-red .bs-datepicker-predefined-btns button.selected {\n  background-color: #d9534f; }\n.theme-red .bs-datepicker-body table td span.selected,\n.theme-red .bs-datepicker-body table td.selected span,\n.theme-red .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-red .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #d9534f; }\n.theme-red .bs-datepicker-body table td.week span {\n  color: #d9534f; }\n.theme-red .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #d9534f;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n.theme-orange .bs-datepicker-head {\n  background-color: #f0ad4e; }\n.theme-orange .btn-today-wrapper .btn-success, .theme-orange .btn-clear-wrapper .btn-success {\n  background-color: #f0ad4e;\n  border-color: #f0ad4e; }\n.theme-orange .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active:focus, .theme-orange .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active:focus {\n  box-shadow: none; }\n.theme-orange .btn-today-wrapper .btn-success:focus, .theme-orange .btn-clear-wrapper .btn-success:focus {\n  box-shadow: none; }\n.theme-orange .btn-today-wrapper .btn-success:not(:disabled):not(.disabled):active, .theme-orange .btn-clear-wrapper .btn-success:not(:disabled):not(.disabled):active {\n  background-color: #ED9C29;\n  border-color: #ED9C29; }\n.theme-orange .btn-today-wrapper .btn-success:hover, .theme-orange .btn-clear-wrapper .btn-success:hover {\n  background-color: #FFAC35;\n  border-color: #FFAC35; }\n.theme-orange .bs-datepicker-predefined-btns button.selected {\n  background-color: #f0ad4e; }\n.theme-orange .bs-datepicker-body table td span.selected,\n.theme-orange .bs-datepicker-body table td.selected span,\n.theme-orange .bs-datepicker-body table td span[class*=\"select-\"]:after,\n.theme-orange .bs-datepicker-body table td[class*=\"select-\"] span:after {\n  background-color: #f0ad4e; }\n.theme-orange .bs-datepicker-body table td.week span {\n  color: #f0ad4e; }\n.theme-orange .bs-datepicker-body table td.active-week span:hover {\n  cursor: pointer;\n  background-color: #f0ad4e;\n  color: #fff;\n  opacity: 0.5;\n  transition: 0s; }\n/*# sourceMappingURL=bs-datepicker.css.map */\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm5vZGVfbW9kdWxlcy9zcmMvZGF0ZXBpY2tlci9icy1kYXRlcGlja2VyLnNjc3MiLCJub2RlX21vZHVsZXMvc3JjL2RhdGVwaWNrZXIvdXRpbHMvc2Nzcy92YXJpYWJsZXMuc2NzcyIsIm5vZGVfbW9kdWxlcy9zcmMvZGF0ZXBpY2tlci91dGlscy9zY3NzL21peGlucy5zY3NzIiwibm9kZV9tb2R1bGVzL25neC1ib290c3RyYXAvZGF0ZXBpY2tlci9icy1kYXRlcGlja2VyLmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFHQSxtQkFBQTtBQUNBO0VBQ0UsYUFBYTtFQUNiLG9CQUFvQjtFQUNwQixtQkFBbUI7RUFDbkIsZ0JDUm9CO0VEU3BCLDJCQ05vQjtFRE9wQixrQkFBa0I7RUFDbEIsVUFBVTtFQVlWLFdBQUE7RUFlQSx3QkFBQTtFQXlFQSx3QkFBQTtFQXNPQSxzQkFBQTtFQTJCQSw0QkFBQTtFQXFDQSx3QkFBQTtFQVlBLCtCQUFBO0VBTUEsbUNBQUE7RUFxQkEsMkJBQUEsRUFBNEI7QUF4YjlCO0lBVUksV0FBVztJQUNYLFdBQVc7SUFDWCxjQUFjLEVBQUE7QUFabEI7SUFnQkksV0FBVyxFQUFBO0FBaEJmOzs7Ozs7Ozs7OztJQStCSSxhQUFhLEVBQUE7QUFJZjtJQUNFLGdCQUFnQjtJQUNoQixZQUFZO0lBQ1osYUFBYTtJQUNiLDBCQUEwQjtJQUMxQixtQkFBbUI7SUFTbkIsK0JBQUEsRUFBZ0M7QUFkakM7TUFRRyxXQUFXO01BQ1gscUJBQXFCO01BQ3JCLG1CQUFtQjtNQUNuQixXQUFXLEVBQUE7QUFYZDtNQWdCRyxxQkFBcUI7TUFDckIsbUJBQW1CO01BQ25CLFVBQVU7TUFDVixZQUFZO01BQ1osaUJBQWlCO01BQ2pCLFNBQVM7TUFDVCx1QkFBdUI7TUFDdkIsa0JBQWtCO01BQ2xCLGVBQWU7TUFDZixXQzNEZ0I7TUQ0RGhCLGdCQUFnQixFQUFBO0FBMUJuQjtRQStCSyxvQ0M3Q3VDO1FEOEN2QyxjQzdDc0I7UUQ4Q3RCLG1CQUFtQixFQUFBO0FBakN4QjtRQXNDSyxrQkFBa0I7UUFDbEIsV0FBVztRQUNYLFlBQVksRUFBQTtBQXhDakI7VUEyQ08sZUFBZTtVQUNmLGNBQWM7VUFDZCxxQkFBcUI7VUFDckIsa0JBQWtCO1VBQ2xCLFlBQVk7VUFDWixXQUFXO1VBQ1gsa0JBQWtCLEVBQUE7QUFqRHpCO1FBc0RLLG1CQUFtQjtRQUNuQixnQkFBZ0I7UUFDaEIsZUFBZSxFQUFBO0FBS3BCO0lBR0ssb0NBQW9DLEVBQUE7QUFIekM7SUFNSyxvQ0FBb0MsRUFBQTtBQU0xQztJQUNFLGFBQWE7SUFDYiwwQkFBMEI7SUFDMUIsaUJBQWlCO0lBQ2pCLGdCQUFnQjtJQUNoQix5QkM1R3FCO0lEbUhyQiw4QkFBQSxFQUErQjtBQVpoQztNQVFHLGtCQUFrQjtNQUNsQixVQUFVLEVBQUE7QUFUYjtNQWNHLFdBQVc7TUFDWCx5QkFBeUI7TUFDekIsaUJBQWlCO01BcUhqQixtQ0FBQTtNQXlDQSxvQ0FBQSxFQUFxQztBQTlLeEM7UUFtQkssZUFBZTtRQUNmLGNDOUhpQjtRRCtIakIsZ0JBQWdCO1FBQ2hCLGtCQUFrQixFQUFBO0FBdEJ2QjtRQTBCSyxjQ25JaUI7UURvSWpCLGtCQUFrQjtRQUNsQixrQkFBa0I7UUFDbEIsVUFBVSxFQUFBO0FBN0JmO1VBZ0NPLGNBQWM7VUFDZCxjQUFjO1VBQ2QsZUFBZTtVQUNmLGtCQUFrQjtVQUNsQixjQUFBO1VBQ0Esc0JBQXNCO1VBQ3RCLHlCQUF5QjtVQUN6QixxQkFBcUIsRUFBQTtBQXZDNUI7VUE0Q08sZUFBZSxFQUFBO0FBNUN0Qjs7VUFpRE8seUJDdkplO1VEd0pmLGNBQWMsRUFBQTtBQWxEckI7O1VBdURPLHlCQzdKZTtVRDhKZixjQUFjO1VBQ2QsZUFBZSxFQUFBO0FBekR0Qjs7VUE4RE8sY0N4S2UsRUFBQTtBRDBHdEI7O1VBbUVPLFdDOUtZLEVBQUE7QUQyR25COztVQXdFTywwQkFBMEIsRUFBQTtBQXhFakM7VUE0RU8sa0JBQWtCLEVBQUE7QUE1RXpCO1lBK0VTLFNBQVMsRUFBQTtBQS9FbEI7WUFtRlMsVUFBVSxFQUFBO0FBbkZuQjs7OztVQTJGTyxXQUFXO1VBQ1gsY0FBYztVQUNkLGtCQUFrQjtVQUNsQixXQUFXO1VBQ1gsV0FBVztVQUNYLFlBQVk7VUFDWixnQkFBZ0I7VUFDaEIsTUFBTTtVQUNOLGtCQUFrQixFQUFBO0FBbkd6Qjs7VUF3R08sV0FBVztVQUNYLGNBQWM7VUFDZCxrQkFBa0I7VUFDbEIsV0FBVztVQUNYLFFBQVE7VUFDUixXQUFXO1VBQ1gsVUFBVTtVQUNWLFdBQVc7VUFDWCx1QkFBdUI7VUFDdkIsdUJBQXVCLEVBQUE7QUFqSDlCO1VBcUhPLFVBQVUsRUFBQTtBQXJIakI7VUF5SE8sMEJBQTBCO1VBQzFCLFdBQVc7VUFDWCxVQUFVLEVBQUE7QUEzSGpCOztVQWdJTyxrQkFBa0I7VUFDbEIsV0M1T1ksRUFBQTtBRDJHbkI7OztRQTJJUyxtQkNqUGEsRUFBQTtBRHNHdEI7UUFnSk8sV0FBVztRQUNYLFlBQVk7UUFDWixpQkFBaUIsRUFBQTtBQWxKeEI7VUFxSlMsVUFBVSxFQUFBO0FBckpuQjtVQXdKUyxVQUFVO1VBQ1YsT0FBTyxFQUFBO0FBekpoQjtVQTRKUyxVQUFVO1VBQ1YsT0FBTyxFQUFBO0FBN0poQjs7Ozs7O1FBd0tTLG1CQzlRYTtRRCtRYixXQUFXLEVBQUE7QUF6S3BCO1FBbUxXLDBCQUEwQjtRQUMxQixPQUFPO1FBQ1AsV0FBVyxFQUFBO0FBckx0QjtRQStMVywwQkFBMEIsRUFBQTtBQS9MckM7UUF3TVMsV0FBVztRQUNYLFlBQVk7UUFDWixpQkFBaUI7UUFDakIsY0FBYyxFQUFBO0FBM012QjtRQWtOVyxrQkFBa0IsRUFBQTtBQWxON0I7UUEwTk8sWUFBWSxFQUFBO0FBMU5uQjtVQTZOUyxZQUFZO1VBQ1osbUJBQW1CLEVBQUE7QUExVS9CO0lBbVZJLGNDaFZxQjtJRGlWckIsZUFBZTtJQUNmLGtCQUFrQjtJQUNsQixZQUFZO0lBQ1osaUJBQWlCO0lBQ2pCLG1CQUFtQjtJQUNuQix5QkNwVnFCO0lEcVZyQixtQkFBbUI7SUFDbkIsZUFBZTtJQUNmLHlCQUF5QjtJQUN6QixzQkFBc0I7SUFDdEIseUJBQXlCO0lBQ3pCLHFCQUFxQixFQUFBO0FBL1Z6QjtNQWtXTSxXQUFXO01BQ1gsV0FBVztNQUNYLFlBQVk7TUFDWixxQkFBcUI7TUFDckIsaUJBQWlCO01BQ2pCLDJCQUEyQjtNQUMzQiwyZ0JBQTJnQixFQUFBO0FBSy9nQjtJQUNFLDBCQUEwQixFQUFBO0FBRDNCO01BSUcsaUJBQWlCLEVBQUE7QUFKcEI7TUFRRyxnQkFBZ0I7TUFDaEIsa0JBQWtCLEVBQUE7QUFUckI7UUFZSyxtQkFBbUIsRUFBQTtBQVp4QjtRQWdCSyxXQUFXO1FBQ1gsY0FBYztRQUNkLFdBQVc7UUFDWCxZQUFZO1FBQ1osK1lBQStZO1FBQy9ZLGtCQUFrQjtRQUNsQixTQUFTO1FBQ1QsVUFBVSxFQUFBO0FBdkJmO1FBMkJLLFdBQVcsRUFBQTtBQTNCaEI7UUErQkssWUFBWSxFQUFBO0FBTWxCO0lBQ0UsYUFBYSxFQUFBO0FBblpqQjtJQXVaSSxhQUFhLEVBQUE7QUFDYjtNQXhaSjtRQXlaTSxzQkFBc0IsRUFBQSxFQUV6QjtBQUdEO0lBQ0UsYUFBYTtJQUNiLGdCQ25ha0IsRUFBQTtBRHVhbkI7SUFFRyxXQUFXO0lBQ1gsY0FBYztJQUNkLFlBQVk7SUFDWix5QkM5Wm1CO0lEK1puQixrQkFBa0I7SUFDbEIsV0MxYWdCO0lEMmFoQixTQUFTO0lBQ1QsbUJBQW1CO0lBQ25CLGVBQWU7SUFDZixnQkFBZ0I7SUFDaEIsZ0JBQWdCLEVBQUE7QUFabkI7TUFlSyx5QkN2YWlCLEVBQUE7QUQ2YXZCO0lBQ0UsYUFBYTtJQUNiLG1CQUFtQjtJQUNuQix5QkFBeUI7SUFDekIsaUJBQWlCO0lBQ2pCLDZCQ3picUIsRUFBQTtBRG9idEI7TUFRRyxpQkFBaUIsRUFBQTtBQVJwQjtNQVlHLGFBQWE7TUFDYixtQkFBbUIsRUFBQTtBQWJ0Qjs7TUFrQkcsWUFBWSxFQUFBO0FBbEJmOztNQXNCRyxZQUFZLEVBQUE7QUF0QmY7O01BMkJHLGNBQWMsRUFBQTtBQUtwQixtQkFBQTtBQUVFO0VBQ0UsZUFBZSxFQUFBO0FBR2pCO0VBQ0UsY0M3ZHFCO0VEOGRyQixtQkFBbUIsRUFBQTtBQUdyQjtFQUNFLHFCQUFxQjtFQUNyQixtQkFBbUI7RUFDbkIsa0JBQWtCLEVBQUE7QUFIbkI7SUFNRyxXQUFXO0lBQ1gsWUFBWTtJQUNaLGtCQUFrQjtJQUNsQixTQUFTO0lBQ1QseUJDdGVtQjtJRHVlbkIsY0M1ZW1CO0lENmVuQixlQUFlO0lBQ2YsZ0JBQWdCO0lBQ2hCLHNCQUFzQjtJQUN0QixjQUFjO0lBQ2QsVUFBVTtJQUNWLGdCQUFnQixFQUFBO0FBakJuQjtNQW9CSyx5QkMvZWlCLEVBQUE7QUQyZHRCO0lBeUJHLFdBQVc7SUFDWCxZQUFZO0lBQ1osbUJBQW1CO0lBQ25CLGtCQUFrQjtJQUNsQix5QkM1Zm1CLEVBQUE7QURxZHpCO0VBNENJLHlCQUF5QjtFQUN6QixlQUFlO0VBQ2YsWUFBWTtFQUNaLG1CQUFtQjtFQUNuQix5QkNyZ0JxQjtFRHNnQnJCLGdCQy9nQmtCO0VEZ2hCbEIsY0N6Z0JxQjtFRDBnQnJCLGVBQWUsRUFBQTtBQW5EbkI7SUFzRE0sdUJBQXVCO0lBQ3ZCLGdCQUFnQixFQUFBO0FBS3RCOztFQUVFLGFBQWEsRUFBQTtBQUdmLHlCQUFBO0FBQ0E7RUFFSTtJQUNFLGFBQWEsRUFBQTtJQURkO01BSUcsZ0JBQWdCO01BQ2hCLGNBQWMsRUFBQSxFQUNmO0FBS1AsWUFBQTtBRTFpQkU7RUFFSSxzQkRhZ0IsRUFBQTtBQ2ZwQjtFQU9NLHNCRFFjO0VDUGQsa0JET2MsRUFBQTtBQ2ZwQjtFQVlRLGdCQUFnQixFQUFBO0FBWnhCO0VBZ0JNLGdCQUFnQixFQUFBO0FBaEJ0QjtFQTZGUSx5QkQ3RG9CO0VDOERwQixxQkQ5RG9CLEVBQUE7QUNoQzVCO0VBa0dRLHlCRHpFbUI7RUMwRW5CLHFCRDFFbUIsRUFBQTtBQ3pCM0I7RUEyR1Usc0JENUZVLEVBQUE7QUNmcEI7Ozs7RUF1SFUsc0JEeEdVLEVBQUE7QUNmcEI7RUEySFUsV0Q1R1UsRUFBQTtBQ2ZwQjtFQStIVSxlQUFlO0VBQ2Ysc0JEakhVO0VDa0hWLFdEL0hVO0VDZ0lWLFlBQVk7RUFDWixjQUFjLEVBQUE7QUFuSXhCO0VBRUkseUJEY21CLEVBQUE7QUNoQnZCO0VBT00seUJEU2lCO0VDUmpCLHFCRFFpQixFQUFBO0FDaEJ2QjtFQVlRLGdCQUFnQixFQUFBO0FBWnhCO0VBZ0JNLGdCQUFnQixFQUFBO0FBaEJ0QjtFQXVCUSx5QkRVa0I7RUNUbEIscUJEU2tCLEVBQUE7QUNqQzFCO0VBNEJRLHlCREZpQjtFQ0dqQixxQkRIaUIsRUFBQTtBQzFCekI7RUEyR1UseUJEM0ZhLEVBQUE7QUNoQnZCOzs7O0VBdUhVLHlCRHZHYSxFQUFBO0FDaEJ2QjtFQTJIVSxjRDNHYSxFQUFBO0FDaEJ2QjtFQStIVSxlQUFlO0VBQ2YseUJEaEhhO0VDaUhiLFdEL0hVO0VDZ0lWLFlBQVk7RUFDWixjQUFjLEVBQUE7QUFuSXhCO0VBRUkseUJEZW1CLEVBQUE7QUNqQnZCO0VBT00seUJEVWlCO0VDVGpCLHFCRFNpQixFQUFBO0FDakJ2QjtFQVlRLGdCQUFnQixFQUFBO0FBWnhCO0VBZ0JNLGdCQUFnQixFQUFBO0FBaEJ0QjtFQXFDUSx5QkRIaUI7RUNJakIscUJESmlCLEVBQUE7QUNsQ3pCO0VBMENRLHlCRGZnQjtFQ2dCaEIscUJEaEJnQixFQUFBO0FDM0J4QjtFQTJHVSx5QkQxRmEsRUFBQTtBQ2pCdkI7Ozs7RUF1SFUseUJEdEdhLEVBQUE7QUNqQnZCO0VBMkhVLGNEMUdhLEVBQUE7QUNqQnZCO0VBK0hVLGVBQWU7RUFDZix5QkQvR2E7RUNnSGIsV0QvSFU7RUNnSVYsWUFBWTtFQUNaLGNBQWMsRUFBQTtBQW5JeEI7RUFFSSx5QkRnQm1CLEVBQUE7QUNsQnZCO0VBT00seUJEV2lCO0VDVmpCLHFCRFVpQixFQUFBO0FDbEJ2QjtFQVlRLGdCQUFnQixFQUFBO0FBWnhCO0VBZ0JNLGdCQUFnQixFQUFBO0FBaEJ0QjtFQW1EUSx5QkRoQnNCO0VDaUJ0QixxQkRqQnNCLEVBQUE7QUNuQzlCO0VBd0RRLHlCRDVCcUI7RUM2QnJCLHFCRDdCcUIsRUFBQTtBQzVCN0I7RUEyR1UseUJEekZhLEVBQUE7QUNsQnZCOzs7O0VBdUhVLHlCRHJHYSxFQUFBO0FDbEJ2QjtFQTJIVSxjRHpHYSxFQUFBO0FDbEJ2QjtFQStIVSxlQUFlO0VBQ2YseUJEOUdhO0VDK0diLFdEL0hVO0VDZ0lWLFlBQVk7RUFDWixjQUFjLEVBQUE7QUFuSXhCO0VBRUkseUJEaUJtQixFQUFBO0FDbkJ2QjtFQU9NLHlCRFlpQjtFQ1hqQixxQkRXaUIsRUFBQTtBQ25CdkI7RUFZUSxnQkFBZ0IsRUFBQTtBQVp4QjtFQWdCTSxnQkFBZ0IsRUFBQTtBQWhCdEI7RUErRVEseUJEMUNnQjtFQzJDaEIscUJEM0NnQixFQUFBO0FDckN4QjtFQW9GUSx5QkR0RGU7RUN1RGYscUJEdkRlLEVBQUE7QUM5QnZCO0VBMkdVLHlCRHhGYSxFQUFBO0FDbkJ2Qjs7OztFQXVIVSx5QkRwR2EsRUFBQTtBQ25CdkI7RUEySFUsY0R4R2EsRUFBQTtBQ25CdkI7RUErSFUsZUFBZTtFQUNmLHlCRDdHYTtFQzhHYixXRC9IVTtFQ2dJVixZQUFZO0VBQ1osY0FBYyxFQUFBO0FBbkl4QjtFQUVJLHlCRGtCbUIsRUFBQTtBQ3BCdkI7RUFPTSx5QkRhaUI7RUNaakIscUJEWWlCLEVBQUE7QUNwQnZCO0VBWVEsZ0JBQWdCLEVBQUE7QUFaeEI7RUFnQk0sZ0JBQWdCLEVBQUE7QUFoQnRCO0VBaUVRLHlCRDdCbUI7RUM4Qm5CLHFCRDlCbUIsRUFBQTtBQ3BDM0I7RUFzRVEseUJEekNrQjtFQzBDbEIscUJEMUNrQixFQUFBO0FDN0IxQjtFQTJHVSx5QkR2RmEsRUFBQTtBQ3BCdkI7Ozs7RUF1SFUseUJEbkdhLEVBQUE7QUNwQnZCO0VBMkhVLGNEdkdhLEVBQUE7QUNwQnZCO0VBK0hVLGVBQWU7RUFDZix5QkQ1R2E7RUM2R2IsV0QvSFU7RUNnSVYsWUFBWTtFQUNaLGNBQWMsRUFBQTtBQzZkMUIsNENBQTRDIiwiZmlsZSI6Im5vZGVfbW9kdWxlcy9uZ3gtYm9vdHN0cmFwL2RhdGVwaWNrZXIvYnMtZGF0ZXBpY2tlci5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyJAaW1wb3J0ICd1dGlscy9zY3NzL3ZhcmlhYmxlcyc7XG5AaW1wb3J0ICd1dGlscy9zY3NzL21peGlucyc7XG5cbi8qIC5icy1kYXRlcGlja2VyICovXG4uYnMtZGF0ZXBpY2tlciB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGFsaWduLWl0ZW1zOiBzdHJldGNoO1xuICBmbGV4LWZsb3c6IHJvdyB3cmFwO1xuICBiYWNrZ3JvdW5kOiAkbWFpbi1iZztcbiAgYm94LXNoYWRvdzogMCAwIDEwcHggMCAkbWFpbi1ib3gtc2hhZG93O1xuICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gIHotaW5kZXg6IDE7XG5cbiAgJjphZnRlciB7XG4gICAgY2xlYXI6IGJvdGg7XG4gICAgY29udGVudDogJyc7XG4gICAgZGlzcGxheTogYmxvY2s7XG4gIH1cblxuICBicy1kYXktcGlja2VyIHtcbiAgICBmbG9hdDogbGVmdDtcbiAgfVxuXG4gIC8qIGJ1dHRvbiAqL1xuICBidXR0b246aG92ZXIsXG4gIGJ1dHRvbjpmb2N1cyxcbiAgYnV0dG9uOmFjdGl2ZSxcbiAgaW5wdXQ6aG92ZXIsXG4gIGlucHV0OmZvY3VzLFxuICBpbnB1dDphY3RpdmUsXG4gICYtYnRucyBidXR0b246aG92ZXIsXG4gICYtYnRucyBidXR0b246Zm9jdXMsXG4gICYtYnRucyBidXR0b246YWN0aXZlLFxuICAmLXByZWRlZmluZWQtYnRucyBidXR0b246YWN0aXZlLFxuICAmLXByZWRlZmluZWQtYnRucyBidXR0b246Zm9jdXMge1xuICAgIG91dGxpbmU6IG5vbmU7XG4gIH1cblxuICAvKiAuYnMtZGF0ZXBpY2tlci1oZWFkICovXG4gICYtaGVhZCB7XG4gICAgbWluLXdpZHRoOiAyNzBweDtcbiAgICBoZWlnaHQ6IDUwcHg7XG4gICAgcGFkZGluZzogMTBweDtcbiAgICBib3JkZXItcmFkaXVzOiAzcHggM3B4IDAgMDtcbiAgICB0ZXh0LWFsaWduOiBqdXN0aWZ5O1xuXG4gICAgJjphZnRlciB7XG4gICAgICBjb250ZW50OiBcIlwiO1xuICAgICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICAgICAgdmVydGljYWwtYWxpZ246IHRvcDtcbiAgICAgIHdpZHRoOiAxMDAlO1xuICAgIH1cblxuICAgIC8qIC5icy1kYXRlcGlja2VyLWhlYWQgYnV0dG9uICovXG4gICAgYnV0dG9uIHtcbiAgICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICAgIHZlcnRpY2FsLWFsaWduOiB0b3A7XG4gICAgICBwYWRkaW5nOiAwO1xuICAgICAgaGVpZ2h0OiAzMHB4O1xuICAgICAgbGluZS1oZWlnaHQ6IDMwcHg7XG4gICAgICBib3JkZXI6IDA7XG4gICAgICBiYWNrZ3JvdW5kOiB0cmFuc3BhcmVudDtcbiAgICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICAgIGN1cnNvcjogcG9pbnRlcjtcbiAgICAgIGNvbG9yOiAkZm9udC1jb2xvci0wMTtcbiAgICAgIHRyYW5zaXRpb246IDAuM3M7XG5cbiAgICAgICZbZGlzYWJsZWRdLFxuICAgICAgJltkaXNhYmxlZF06aG92ZXIsXG4gICAgICAmW2Rpc2FibGVkXTphY3RpdmUge1xuICAgICAgICBiYWNrZ3JvdW5kOiAkZGlzYWJsZWQtYmFja2dyb3VuZDtcbiAgICAgICAgY29sb3I6ICRkaXNhYmxlZC1jb2xvcjtcbiAgICAgICAgY3Vyc29yOiBub3QtYWxsb3dlZDtcbiAgICAgIH1cblxuICAgICAgJi5uZXh0LFxuICAgICAgJi5wcmV2aW91cyB7XG4gICAgICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICAgICAgd2lkdGg6IDMwcHg7XG4gICAgICAgIGhlaWdodDogMzBweDtcblxuICAgICAgICBzcGFuIHtcbiAgICAgICAgICBmb250LXNpemU6IDI4cHg7XG4gICAgICAgICAgbGluZS1oZWlnaHQ6IDE7XG4gICAgICAgICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICAgICAgICAgIHBvc2l0aW9uOiByZWxhdGl2ZTtcbiAgICAgICAgICBoZWlnaHQ6IDEwMCU7XG4gICAgICAgICAgd2lkdGg6IDEwMCU7XG4gICAgICAgICAgYm9yZGVyLXJhZGl1czogNTAlO1xuICAgICAgICB9XG4gICAgICB9XG5cbiAgICAgICYuY3VycmVudCB7XG4gICAgICAgIGJvcmRlci1yYWRpdXM6IDE1cHg7XG4gICAgICAgIG1heC13aWR0aDogMTU1cHg7XG4gICAgICAgIHBhZGRpbmc6IDAgMTNweDtcbiAgICAgIH1cbiAgICB9XG4gIH1cblxuICAmLWhlYWQge1xuICAgIGJ1dHRvbiB7XG4gICAgICAmOmhvdmVyIHtcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogcmdiYSgwLCAwLCAwLCAwLjEpO1xuICAgICAgfVxuICAgICAgJjphY3RpdmUge1xuICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuMik7XG4gICAgICB9XG4gICAgfVxuICB9XG5cbiAgLyogLmJzLWRhdGVwaWNrZXItYm9keSAqL1xuICAmLWJvZHkge1xuICAgIHBhZGRpbmc6IDEwcHg7XG4gICAgYm9yZGVyLXJhZGl1czogMCAwIDNweCAzcHg7XG4gICAgbWluLWhlaWdodDogMjMycHg7XG4gICAgbWluLXdpZHRoOiAyNzhweDtcbiAgICBib3JkZXI6IDFweCBzb2xpZCAkYm9yZGVyLWNvbG9yO1xuXG4gICAgLmRheXMud2Vla3Mge1xuICAgICAgcG9zaXRpb246IHJlbGF0aXZlO1xuICAgICAgei1pbmRleDogMTtcbiAgICB9XG5cbiAgICAvKiAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlICovXG4gICAgdGFibGUge1xuICAgICAgd2lkdGg6IDEwMCU7XG4gICAgICBib3JkZXItY29sbGFwc2U6IHNlcGFyYXRlO1xuICAgICAgYm9yZGVyLXNwYWNpbmc6IDA7XG5cbiAgICAgIHRoIHtcbiAgICAgICAgZm9udC1zaXplOiAxM3B4O1xuICAgICAgICBjb2xvcjogJGZvbnQtY29sb3ItMDI7XG4gICAgICAgIGZvbnQtd2VpZ2h0OiA0MDA7XG4gICAgICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICAgIH1cblxuICAgICAgdGQge1xuICAgICAgICBjb2xvcjogJGZvbnQtY29sb3ItMDM7XG4gICAgICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICAgICAgcG9zaXRpb246IHJlbGF0aXZlO1xuICAgICAgICBwYWRkaW5nOiAwO1xuXG4gICAgICAgIHNwYW4ge1xuICAgICAgICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgICAgICAgIG1hcmdpbjogMCBhdXRvO1xuICAgICAgICAgIGZvbnQtc2l6ZTogMTNweDtcbiAgICAgICAgICBib3JkZXItcmFkaXVzOiA1MCU7XG4gICAgICAgICAgLyp6LWluZGV4OiAxOyovXG4gICAgICAgICAgLW1vei11c2VyLXNlbGVjdDogbm9uZTtcbiAgICAgICAgICAtd2Via2l0LXVzZXItc2VsZWN0OiBub25lO1xuICAgICAgICAgIC1tcy11c2VyLXNlbGVjdDogbm9uZTtcbiAgICAgICAgfVxuXG4gICAgICAgIC8vIHRvZG86IGNoZWNrIGZpcnN0IDpub3QoLmRpc2FibGVkKSB1c2FnZVxuICAgICAgICAmOm5vdCguZGlzYWJsZWQpOm5vdCgud2Vlaykgc3Bhbjpub3QoLmRpc2FibGVkKTpub3QoLmlzLW90aGVyLW1vbnRoKSB7XG4gICAgICAgICAgY3Vyc29yOiBwb2ludGVyO1xuICAgICAgICB9XG5cbiAgICAgICAgJi5pcy1oaWdobGlnaHRlZDpub3QoLmRpc2FibGVkKTpub3QoLnNlbGVjdGVkKSBzcGFuLFxuICAgICAgICBzcGFuLmlzLWhpZ2hsaWdodGVkOm5vdCguZGlzYWJsZWQpOm5vdCguc2VsZWN0ZWQpIHtcbiAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkaGlnaGxpZ2h0ZWQ7XG4gICAgICAgICAgdHJhbnNpdGlvbjogMHM7XG4gICAgICAgIH1cblxuICAgICAgICAmLmlzLWFjdGl2ZS1vdGhlci1tb250aDpub3QoLmRpc2FibGVkKTpub3QoLnNlbGVjdGVkKSBzcGFuLFxuICAgICAgICBzcGFuLmlzLWFjdGl2ZS1vdGhlci1tb250aDpub3QoLmRpc2FibGVkKTpub3QoLnNlbGVjdGVkKSB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGhpZ2hsaWdodGVkO1xuICAgICAgICAgIHRyYW5zaXRpb246IDBzO1xuICAgICAgICAgIGN1cnNvcjogcG9pbnRlcjtcbiAgICAgICAgfVxuXG4gICAgICAgIHNwYW4uZGlzYWJsZWQsXG4gICAgICAgICYuZGlzYWJsZWQgc3BhbiB7XG4gICAgICAgICAgY29sb3I6ICRmb250LWNvbG9yLTAyO1xuICAgICAgICB9XG5cbiAgICAgICAgc3Bhbi5zZWxlY3RlZCxcbiAgICAgICAgJi5zZWxlY3RlZCBzcGFuIHtcbiAgICAgICAgICBjb2xvcjogJGZvbnQtY29sb3ItMDE7XG4gICAgICAgIH1cblxuICAgICAgICBzcGFuLmlzLW90aGVyLW1vbnRoLFxuICAgICAgICAmLmlzLW90aGVyLW1vbnRoIHNwYW4ge1xuICAgICAgICAgIGNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuMjUpO1xuICAgICAgICB9XG5cbiAgICAgICAgJi5hY3RpdmUge1xuICAgICAgICAgIHBvc2l0aW9uOiByZWxhdGl2ZTtcblxuICAgICAgICAgICYuc2VsZWN0LXN0YXJ0OmJlZm9yZSB7XG4gICAgICAgICAgICBsZWZ0OiAzNSU7XG4gICAgICAgICAgfVxuXG4gICAgICAgICAgJi5zZWxlY3QtZW5kOmJlZm9yZSB7XG4gICAgICAgICAgICBsZWZ0OiAtODUlO1xuICAgICAgICAgIH1cbiAgICAgICAgfVxuXG4gICAgICAgIHNwYW4uYWN0aXZlLnNlbGVjdC1zdGFydDphZnRlcixcbiAgICAgICAgc3Bhbi5hY3RpdmUuc2VsZWN0LWVuZDphZnRlcixcbiAgICAgICAgJi5hY3RpdmUuc2VsZWN0LXN0YXJ0IHNwYW46YWZ0ZXIsXG4gICAgICAgICYuYWN0aXZlLnNlbGVjdC1lbmQgc3BhbjphZnRlciB7XG4gICAgICAgICAgY29udGVudDogXCJcIjtcbiAgICAgICAgICBkaXNwbGF5OiBibG9jaztcbiAgICAgICAgICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gICAgICAgICAgei1pbmRleDogLTE7XG4gICAgICAgICAgd2lkdGg6IDEwMCU7XG4gICAgICAgICAgaGVpZ2h0OiAxMDAlO1xuICAgICAgICAgIHRyYW5zaXRpb246IDAuM3M7XG4gICAgICAgICAgdG9wOiAwO1xuICAgICAgICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICAgICAgfVxuXG4gICAgICAgICY6YmVmb3JlLFxuICAgICAgICBzcGFuOmJlZm9yZSB7XG4gICAgICAgICAgY29udGVudDogXCJcIjtcbiAgICAgICAgICBkaXNwbGF5OiBibG9jaztcbiAgICAgICAgICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gICAgICAgICAgei1pbmRleDogLTE7XG4gICAgICAgICAgdG9wOiA2cHg7XG4gICAgICAgICAgYm90dG9tOiA2cHg7XG4gICAgICAgICAgbGVmdDogLTNweDtcbiAgICAgICAgICByaWdodDogLTJweDtcbiAgICAgICAgICBib3gtc2l6aW5nOiBjb250ZW50LWJveDtcbiAgICAgICAgICBiYWNrZ3JvdW5kOiB0cmFuc3BhcmVudDtcbiAgICAgICAgfVxuXG4gICAgICAgICYuYWN0aXZlLnNlbGVjdC1zdGFydCArIHRkLmFjdGl2ZTpiZWZvcmUge1xuICAgICAgICAgIGxlZnQ6IC0yMCU7XG4gICAgICAgIH1cblxuICAgICAgICAmOmxhc3QtY2hpbGQuYWN0aXZlOmJlZm9yZSB7XG4gICAgICAgICAgYm9yZGVyLXJhZGl1czogMCAzcHggM3B4IDA7XG4gICAgICAgICAgd2lkdGg6IDEyNSU7XG4gICAgICAgICAgbGVmdDogLTI1JTtcbiAgICAgICAgfVxuXG4gICAgICAgIHNwYW5bY2xhc3MqPVwic2VsZWN0LVwiXSxcbiAgICAgICAgJltjbGFzcyo9XCJzZWxlY3QtXCJdIHNwYW4ge1xuICAgICAgICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICAgICAgICBjb2xvcjogJGZvbnQtY29sb3ItMDE7XG4gICAgICAgIH1cbiAgICAgIH1cblxuICAgICAgLyogLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZS5kYXlzICovXG4gICAgICAmLmRheXMge1xuICAgICAgICB0ZCxcbiAgICAgICAgc3BhbiB7XG4gICAgICAgICAgJi5hY3RpdmU6bm90KC5zZWxlY3Qtc3RhcnQpOmJlZm9yZSxcbiAgICAgICAgICAmLmluLXJhbmdlOm5vdCguc2VsZWN0LXN0YXJ0KTpiZWZvcmUge1xuICAgICAgICAgICAgYmFja2dyb3VuZDogJGhpZ2hsaWdodGVkO1xuICAgICAgICAgIH1cbiAgICAgICAgfVxuXG4gICAgICAgIHNwYW4ge1xuICAgICAgICAgIHdpZHRoOiAzMnB4O1xuICAgICAgICAgIGhlaWdodDogMzJweDtcbiAgICAgICAgICBsaW5lLWhlaWdodDogMzJweDtcblxuICAgICAgICAgICYuc2VsZWN0LXN0YXJ0IHtcbiAgICAgICAgICAgIHotaW5kZXg6IDI7XG4gICAgICAgICAgfVxuICAgICAgICAgICYuaXMtaGlnaGxpZ2h0ZWQuaW4tcmFuZ2U6YmVmb3JlIHtcbiAgICAgICAgICAgIHJpZ2h0OiAzcHg7XG4gICAgICAgICAgICBsZWZ0OiAwO1xuICAgICAgICAgIH1cbiAgICAgICAgICAmLmluLXJhbmdlLnNlbGVjdC1lbmQ6YmVmb3JlIHtcbiAgICAgICAgICAgIHJpZ2h0OiA0cHg7XG4gICAgICAgICAgICBsZWZ0OiAwO1xuICAgICAgICAgIH1cbiAgICAgICAgfVxuXG4gICAgICAgIHRkIHtcbiAgICAgICAgICAmLnNlbGVjdC1zdGFydCArIHRkLnNlbGVjdC1lbmQ6YmVmb3JlLFxuICAgICAgICAgICYuc2VsZWN0LXN0YXJ0ICsgdGQuaXMtaGlnaGxpZ2h0ZWQ6YmVmb3JlLFxuICAgICAgICAgICYuYWN0aXZlICsgdGQuaXMtaGlnaGxpZ2h0ZWQ6YmVmb3JlLFxuICAgICAgICAgICYuYWN0aXZlICsgdGQuc2VsZWN0LWVuZDpiZWZvcmUsXG4gICAgICAgICAgJi5pbi1yYW5nZSArIHRkLmlzLWhpZ2hsaWdodGVkOmJlZm9yZSxcbiAgICAgICAgICAmLmluLXJhbmdlICsgdGQuc2VsZWN0LWVuZDpiZWZvcmUge1xuICAgICAgICAgICAgYmFja2dyb3VuZDogJGhpZ2hsaWdodGVkO1xuICAgICAgICAgICAgd2lkdGg6IDEwMCU7XG4gICAgICAgICAgfVxuICAgICAgICB9XG4gICAgICB9XG5cbiAgICAgIC8qIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUud2Vla3MgKi9cbiAgICAgICYud2Vla3Mge1xuICAgICAgICB0ciB7XG4gICAgICAgICAgdGQge1xuICAgICAgICAgICAgJjpudGgtY2hpbGQoMikuYWN0aXZlOmJlZm9yZSB7XG4gICAgICAgICAgICAgIGJvcmRlci1yYWRpdXM6IDNweCAwIDAgM3B4O1xuICAgICAgICAgICAgICBsZWZ0OiAwO1xuICAgICAgICAgICAgICB3aWR0aDogMTAwJTtcbiAgICAgICAgICAgIH1cbiAgICAgICAgICB9XG4gICAgICAgIH1cbiAgICAgIH1cblxuICAgICAgJjpub3QoLndlZWtzKSB7XG4gICAgICAgIHRyIHtcbiAgICAgICAgICB0ZHtcbiAgICAgICAgICAgICY6Zmlyc3QtY2hpbGQ6YmVmb3JlIHtcbiAgICAgICAgICAgICAgYm9yZGVyLXJhZGl1czogM3B4IDAgMCAzcHg7XG4gICAgICAgICAgICB9XG4gICAgICAgICAgfVxuICAgICAgICB9XG4gICAgICB9XG5cbiAgICAgICYueWVhcnMge1xuICAgICAgICB0ZCB7XG4gICAgICAgICAgc3BhbiB7XG4gICAgICAgICAgICB3aWR0aDogNDZweDtcbiAgICAgICAgICAgIGhlaWdodDogNDZweDtcbiAgICAgICAgICAgIGxpbmUtaGVpZ2h0OiA0NXB4O1xuICAgICAgICAgICAgbWFyZ2luOiAwIGF1dG87XG4gICAgICAgICAgfVxuICAgICAgICB9XG5cbiAgICAgICAgdHI6bm90KDpsYXN0LWNoaWxkKSB7XG4gICAgICAgICAgdGQge1xuICAgICAgICAgICAgc3BhbiB7XG4gICAgICAgICAgICAgIG1hcmdpbi1ib3R0b206IDhweDtcbiAgICAgICAgICAgIH1cbiAgICAgICAgICB9XG4gICAgICAgIH1cbiAgICAgIH1cblxuICAgICAgJi5tb250aHMge1xuICAgICAgICB0ZCB7XG4gICAgICAgICAgaGVpZ2h0OiA1MnB4O1xuXG4gICAgICAgICAgc3BhbiB7XG4gICAgICAgICAgICBwYWRkaW5nOiA2cHg7XG4gICAgICAgICAgICBib3JkZXItcmFkaXVzOiAxNXB4O1xuICAgICAgICAgIH1cbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cbiAgfVxuXG4gIC8qIC5jdXJyZW50LXRpbWVkYXRlICovXG4gIC5jdXJyZW50LXRpbWVkYXRlIHtcbiAgICBjb2xvcjogJGZvbnQtY29sb3ItMDM7XG4gICAgZm9udC1zaXplOiAxNXB4O1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICBoZWlnaHQ6IDMwcHg7XG4gICAgbGluZS1oZWlnaHQ6IDMwcHg7XG4gICAgYm9yZGVyLXJhZGl1czogMjBweDtcbiAgICBib3JkZXI6IDFweCBzb2xpZCAkYm9yZGVyLWNvbG9yO1xuICAgIG1hcmdpbi1ib3R0b206IDEwcHg7XG4gICAgY3Vyc29yOiBwb2ludGVyO1xuICAgIHRleHQtdHJhbnNmb3JtOiB1cHBlcmNhc2U7XG4gICAgLW1vei11c2VyLXNlbGVjdDogbm9uZTtcbiAgICAtd2Via2l0LXVzZXItc2VsZWN0OiBub25lO1xuICAgIC1tcy11c2VyLXNlbGVjdDogbm9uZTtcblxuICAgIHNwYW46bm90KDplbXB0eSk6YmVmb3JlIHtcbiAgICAgIGNvbnRlbnQ6IFwiXCI7XG4gICAgICB3aWR0aDogMTVweDtcbiAgICAgIGhlaWdodDogMTZweDtcbiAgICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICAgIG1hcmdpbi1yaWdodDogNHB4O1xuICAgICAgdmVydGljYWwtYWxpZ246IHRleHQtYm90dG9tO1xuICAgICAgYmFja2dyb3VuZDogdXJsKGRhdGE6aW1hZ2UvcG5nO2Jhc2U2NCxpVkJPUncwS0dnb0FBQUFOU1VoRVVnQUFBQThBQUFBUUNBWUFBQURKVmlVRUFBQUJNa2xFUVZRb1U5VlR3VzNDUUJDY09VZ0J0RUJLU0F1a0FuQktNRSt3RkNBbFlJaGs4c1FseEZBQnRKQVNjQXN1QVBCRWV3WWN4Q1A4b3V4clBEc3phNjF1aVZOMW82Uk5IRDRodFNDbXE0OVJmTzcxQnZNSnFCQmtJVFJmMWttVVc0OW5RUkM5aDFJNUFabEJDbGFMOGFQMWZLZ09PeEN4OGFTTHMrUTE5ZVp1Tk84UW1QcUpSdERGZ3V5N09BY0RiSlBzKy9CS1ZQRElQcnZEMlpKZ1dBbVZlN08wckkwVnFzMXNleVdVWHB1Sm9wcFlDYTVMK1UrK05wTlBrcjVPRTJvTWRBUnNiM2d5a0pUNXlkWmNMOFo5V3c2MG54ZzJMaGpPTjlsaTlPd1haem8reExicDNuQzJzOUNMMlJydWVHeVZyZ3dObThIcHNDelo5RUVXNmtxWGxvMUdRZTAzRnpQLzdXOEhsMGRCdHU3QmY3enQ2bUl3dlgxUnZ6RENtNytxM21BVzBEbC9HUGRVQ2VYclpMVDlCckRyR2ttNHFsUHZBQUFBQUVsRlRrU3VRbUNDKTtcbiAgICB9XG4gIH1cblxuICAvKiAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSAqL1xuICAmLW11bHRpcGxlIHtcbiAgICBib3JkZXItcmFkaXVzOiA0cHggMCAwIDRweDtcblxuICAgICYgKyAmIHtcbiAgICAgIG1hcmdpbi1sZWZ0OiAxMHB4O1xuICAgIH1cblxuICAgIC5icy1kYXRlcGlja2VyIHtcbiAgICAgIGJveC1zaGFkb3c6IG5vbmU7XG4gICAgICBwb3NpdGlvbjogcmVsYXRpdmU7XG5cbiAgICAgICY6bm90KDpsYXN0LWNoaWxkKSB7XG4gICAgICAgIHBhZGRpbmctcmlnaHQ6IDEwcHg7XG4gICAgICB9XG5cbiAgICAgICYgKyAuYnMtZGF0ZXBpY2tlcjphZnRlciB7XG4gICAgICAgIGNvbnRlbnQ6IFwiXCI7XG4gICAgICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgICAgICB3aWR0aDogMTRweDtcbiAgICAgICAgaGVpZ2h0OiAxMHB4O1xuICAgICAgICBiYWNrZ3JvdW5kOiB1cmwoZGF0YTppbWFnZS9wbmc7YmFzZTY0LGlWQk9SdzBLR2dvQUFBQU5TVWhFVWdBQUFBOEFBQUFLQ0FZQUFBQnJHd1Q1QUFBQTFFbEVRVlFvVTQyUnNRckNVQXhGNzdWdUR1N080b01XVy8vQlVSQkJwWnZnS2s0dUlyam9xS09UZitEb3BJTzR1WWdndEZUZnczK3BrUXFDVzEvRzVKN2tKaUZ5NG01TXhVbHhBemdJUEhYK2x6TVB6dXBSWWxZZ3hpUjd2cXNPUDhZS3pzVHgweXhGTUNVWitxN2FaemxyK092Z29XY0FGeUFIZ2F0MmpMV3U0ODI1MkRkcUFpaERKR1NTSk5VVXhZbVFqczMraFBRQmxBaDJyRzJMQ09QbmF3M0lpR0RYOTlUUkNzN0FTSnNOaFVPQTdkL0xjdUh2UkcyMkZJWnZzTlh3MU1YNlZaRXhDaWxPUUtFZmVMWHIvMTArYUM5SG83YXJoN29BQUFBQVNVVk9SSzVDWUlJPSk7XG4gICAgICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICAgICAgdG9wOiAyNXB4O1xuICAgICAgICBsZWZ0OiAtOHB4O1xuICAgICAgfVxuXG4gICAgICAubGVmdCB7XG4gICAgICAgIGZsb2F0OiBsZWZ0O1xuICAgICAgfVxuXG4gICAgICAucmlnaHQge1xuICAgICAgICBmbG9hdDogcmlnaHQ7XG4gICAgICB9XG4gICAgfVxuICB9XG5cbiAgLyogLmJzLWRhdGVwaWNrZXItYnRucyAqL1xuICAmLWNvbnRhaW5lciB7XG4gICAgcGFkZGluZzogMTVweDtcbiAgfVxuXG4gIC5icy1tZWRpYS1jb250YWluZXIge1xuICAgIGRpc3BsYXk6IGZsZXg7XG4gICAgQG1lZGlhKG1heC13aWR0aDogNzY4cHgpIHtcbiAgICAgIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XG4gICAgfVxuICB9XG5cbiAgLyouYnMtZGF0ZXBpY2tlci1jdXN0b20tcmFuZ2UgKi9cbiAgJi1jdXN0b20tcmFuZ2Uge1xuICAgIHBhZGRpbmc6IDE1cHg7XG4gICAgYmFja2dyb3VuZDogJGN1c3RvbS1yYW5nZS1iZztcbiAgfVxuXG4gIC8qIC5icy1kYXRlcGlja2VyLXByZWRlZmluZWQtYnRucyAqL1xuICAmLXByZWRlZmluZWQtYnRucyB7XG4gICAgYnV0dG9uIHtcbiAgICAgIHdpZHRoOiAxMDAlO1xuICAgICAgZGlzcGxheTogYmxvY2s7XG4gICAgICBoZWlnaHQ6IDMwcHg7XG4gICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkYnRuLWJnMjtcbiAgICAgIGJvcmRlci1yYWRpdXM6IDRweDtcbiAgICAgIGNvbG9yOiAkZm9udC1jb2xvci0wMTtcbiAgICAgIGJvcmRlcjogMDtcbiAgICAgIG1hcmdpbi1ib3R0b206IDEwcHg7XG4gICAgICBwYWRkaW5nOiAwIDE4cHg7XG4gICAgICB0ZXh0LWFsaWduOiBsZWZ0O1xuICAgICAgdHJhbnNpdGlvbjogMC4zcztcblxuICAgICAgJjpob3ZlciB7XG4gICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRidG4tYmcyLWhvdmVyO1xuICAgICAgfVxuICAgIH1cbiAgfVxuXG4gIC8qIC5icy1kYXRlcGlja2VyLWJ1dHRvbnMgKi9cbiAgJi1idXR0b25zIHtcbiAgICBkaXNwbGF5OiBmbGV4O1xuICAgIGZsZXgtZmxvdzogcm93IHdyYXA7XG4gICAganVzdGlmeS1jb250ZW50OiBmbGV4LWVuZDtcbiAgICBwYWRkaW5nLXRvcDogMTBweDtcbiAgICBib3JkZXItdG9wOiAxcHggc29saWQgJGJvcmRlci1jb2xvcjtcblxuICAgIC5idG4tZGVmYXVsdCB7XG4gICAgICBtYXJnaW4tbGVmdDogMTBweDtcbiAgICB9XG5cbiAgICAuYnRuLXRvZGF5LXdyYXBwZXIge1xuICAgICAgZGlzcGxheTogZmxleDtcbiAgICAgIGZsZXgtZmxvdzogcm93IHdyYXA7XG4gICAgfVxuXG4gICAgLmNsZWFyLXJpZ2h0LFxuICAgIC50b2RheS1yaWdodCB7XG4gICAgICBmbGV4LWdyb3c6IDA7XG4gICAgfVxuICAgIC5jbGVhci1sZWZ0LFxuICAgIC50b2RheS1sZWZ0IHtcbiAgICAgIGZsZXgtZ3JvdzogMTtcbiAgICB9XG5cbiAgICAuY2xlYXItY2VudGVyLFxuICAgIC50b2RheS1jZW50ZXIge1xuICAgICAgZmxleC1ncm93OiAwLjU7XG4gICAgfVxuICB9XG59XG5cbi8qIC5icy10aW1lcGlja2VyICovXG4uYnMtdGltZXBpY2tlciB7XG4gICYtY29udGFpbmVyIHtcbiAgICBwYWRkaW5nOiAxMHB4IDA7XG4gIH1cblxuICAmLWxhYmVsIHtcbiAgICBjb2xvcjogJGZvbnQtY29sb3ItMDM7XG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcbiAgfVxuXG4gICYtY29udHJvbHMge1xuICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICB2ZXJ0aWNhbC1hbGlnbjogdG9wO1xuICAgIG1hcmdpbi1yaWdodDogMTBweDtcblxuICAgIGJ1dHRvbiB7XG4gICAgICB3aWR0aDogMjBweDtcbiAgICAgIGhlaWdodDogMjBweDtcbiAgICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICAgIGJvcmRlcjogMDtcbiAgICAgIGJhY2tncm91bmQtY29sb3I6ICRidG4tYmc7XG4gICAgICBjb2xvcjogJGZvbnQtY29sb3ItMDM7XG4gICAgICBmb250LXNpemU6IDE2cHg7XG4gICAgICBmb250LXdlaWdodDogNzAwO1xuICAgICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcbiAgICAgIGxpbmUtaGVpZ2h0OiAwO1xuICAgICAgcGFkZGluZzogMDtcbiAgICAgIHRyYW5zaXRpb246IDAuM3M7XG5cbiAgICAgICY6aG92ZXIge1xuICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkYnRuLWJnLWhvdmVyO1xuICAgICAgfVxuICAgIH1cblxuICAgIGlucHV0IHtcbiAgICAgIHdpZHRoOiAzNXB4O1xuICAgICAgaGVpZ2h0OiAyNXB4O1xuICAgICAgYm9yZGVyLXJhZGl1czogMTNweDtcbiAgICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICAgIGJvcmRlcjogMXB4IHNvbGlkICRib3JkZXItY29sb3I7XG4gICAgfVxuICB9XG5cbiAgLnN3aXRjaC10aW1lLWZvcm1hdCB7XG4gICAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcbiAgICBtaW4td2lkdGg6IDU0cHg7XG4gICAgaGVpZ2h0OiAyNXB4O1xuICAgIGJvcmRlci1yYWRpdXM6IDIwcHg7XG4gICAgYm9yZGVyOiAxcHggc29saWQgJGJvcmRlci1jb2xvcjtcbiAgICBiYWNrZ3JvdW5kOiAkbWFpbi1iZztcbiAgICBjb2xvcjogJGZvbnQtY29sb3ItMDM7XG4gICAgZm9udC1zaXplOiAxM3B4O1xuXG4gICAgaW1nIHtcbiAgICAgIHZlcnRpY2FsLWFsaWduOiBpbml0aWFsO1xuICAgICAgbWFyZ2luLWxlZnQ6IDRweDtcbiAgICB9XG4gIH1cbn1cblxuYnMtZGF0ZXBpY2tlci1jb250YWluZXIsXG5icy1kYXRlcmFuZ2VwaWNrZXItY29udGFpbmVyIHtcbiAgei1pbmRleDogMTA4MDtcbn1cblxuLyogc2NyZWVuIHNpemUgPCAxMDI0cHggKi9cbkBtZWRpYSAobWF4LXdpZHRoOiA3NjhweCkge1xuICAuYnMtZGF0ZXBpY2tlciB7XG4gICAgJi1tdWx0aXBsZSB7XG4gICAgICBkaXNwbGF5OiBmbGV4O1xuXG4gICAgICAmICsgJiB7XG4gICAgICAgIG1hcmdpbi10b3A6IDEwcHg7XG4gICAgICAgIG1hcmdpbi1sZWZ0OiAwO1xuICAgICAgfVxuICAgIH1cbiAgfVxufVxuXG4vKiB0aGVtaW5nICovXG5AZWFjaCAkbmFtZSwgJGNvbG9yIGluICR0aGVtZS1saXN0IHtcbiAgQGluY2x1ZGUgdGhlbWluZygkbmFtZSwgJGNvbG9yKTtcbn1cbiIsIiRtYWluLWJnOiAgICAgICAgICNmZmYgIWRlZmF1bHQ7XG4kY3VzdG9tLXJhbmdlLWJnOiAjZWVlICFkZWZhdWx0O1xuXG4kbWFpbi1ib3gtc2hhZG93OiAjYWFhICFkZWZhdWx0O1xuXG4kZm9udC1jb2xvci0wMTogICAjZmZmICFkZWZhdWx0O1xuJGZvbnQtY29sb3ItMDI6ICAgIzlhYWVjMSAhZGVmYXVsdDtcbiRmb250LWNvbG9yLTAzOiAgICM1NDcwOGIgIWRlZmF1bHQ7XG5cbiRib3JkZXItY29sb3I6ICAgICNlOWVkZjAgIWRlZmF1bHQ7XG4kaGlnaGxpZ2h0ZWQ6ICAgICAjZTllZGYwICFkZWZhdWx0O1xuXG4kYnRuLWJnOiAgICAgICAgICAjZTllZGYwICFkZWZhdWx0O1xuJGJ0bi1iZy1ob3ZlcjogICAgI2Q1ZGFkZCAhZGVmYXVsdDtcblxuJGJ0bi1iZzI6ICAgICAgICAgIzlhYWVjMSAhZGVmYXVsdDtcbiRidG4tYmcyLWhvdmVyOiAgICM1NDcwOGIgIWRlZmF1bHQ7XG5cbiR0aGVtZS1ncmF5OiAgICAgICM3NzcgIWRlZmF1bHQ7XG4kdGhlbWUtZ3JlZW46ICAgICAjNWNiODVjICFkZWZhdWx0O1xuJHRoZW1lLWJsdWU6ICAgICAgIzViYzBkZSAhZGVmYXVsdDtcbiR0aGVtZS1kYXJrLWJsdWU6ICMzMzdhYjcgIWRlZmF1bHQ7XG4kdGhlbWUtcmVkOiAgICAgICAjZDk1MzRmICFkZWZhdWx0O1xuJHRoZW1lLW9yYW5nZTogICAgI2YwYWQ0ZSAhZGVmYXVsdDtcblxuJGRpc2FibGVkLWJhY2tncm91bmQ6ICByZ2JhKDIyMSwgMjIxLCAyMjEsIDAuMykgIWRlZmF1bHQ7XG4kZGlzYWJsZWQtY29sb3I6ICAgICAgICNmNWY1ZjUgIWRlZmF1bHQ7XG5cbiRob3Zlci10aGVtZS1kZWZhdWx0OiAjNkY2RTZFO1xuJGhvdmVyLXRoZW1lLWdyZWVuOiAjMjE4ODM4O1xuJGhvdmVyLXRoZW1lLWJsdWU6ICMzQUIzRDc7XG4kaG92ZXItdGhlbWUtZGFyay1ibHVlOiAjMkM2RkE5O1xuJGhvdmVyLXRoZW1lLW9yYW5nZTogI0ZGQUMzNTtcbiRob3Zlci10aGVtZS1yZWQ6ICNFMzM3MzI7XG5cbiRhY3RpdmUtdGhlbWUtZGVmYXVsdDogIzYxNjE2MTtcbiRhY3RpdmUtdGhlbWUtZ3JlZW46ICMxZTdlMzQ7XG4kYWN0aXZlLXRoZW1lLWJsdWU6ICMyQUE4Q0Q7XG4kYWN0aXZlLXRoZW1lLWRhcmstYmx1ZTogIzI2NjQ5ODtcbiRhY3RpdmUtdGhlbWUtb3JhbmdlOiAjRUQ5QzI5O1xuJGFjdGl2ZS10aGVtZS1yZWQ6ICNEMjM1MzE7XG5cbiR0aGVtZS1saXN0OiAoXG4gICdkZWZhdWx0JzogJHRoZW1lLWdyYXksXG4gICdncmVlbic6ICR0aGVtZS1ncmVlbixcbiAgJ2JsdWUnOiAkdGhlbWUtYmx1ZSxcbiAgJ2RhcmstYmx1ZSc6ICR0aGVtZS1kYXJrLWJsdWUsXG4gICdyZWQnOiAkdGhlbWUtcmVkLFxuICAnb3JhbmdlJzogJHRoZW1lLW9yYW5nZSxcbikgIWRlZmF1bHQ7XG4iLCJAaW1wb3J0ICd2YXJpYWJsZXMnO1xuXG5AbWl4aW4gdGhlbWluZygkbmFtZSwgJGNvbG9yKSB7XG4gIC50aGVtZS0jeyRuYW1lfSB7XG4gICAgLmJzLWRhdGVwaWNrZXItaGVhZCB7XG4gICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkY29sb3I7XG4gICAgfVxuXG4gICAgLmJ0bi10b2RheS13cmFwcGVyLCAuYnRuLWNsZWFyLXdyYXBwZXIge1xuICAgICAgLmJ0bi1zdWNjZXNzIHtcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGNvbG9yO1xuICAgICAgICBib3JkZXItY29sb3I6ICRjb2xvcjtcbiAgICAgIH1cbiAgICAgIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUge1xuICAgICAgICAmOmZvY3VzIHtcbiAgICAgICAgICBib3gtc2hhZG93OiBub25lO1xuICAgICAgICB9XG4gICAgICB9XG4gICAgICAuYnRuLXN1Y2Nlc3M6Zm9jdXMge1xuICAgICAgICBib3gtc2hhZG93OiBub25lO1xuICAgICAgfVxuICAgIH1cblxuICAgIEBpZiAkbmFtZSA9PSAnZ3JlZW4nIHtcbiAgICAgIC5idG4tdG9kYXktd3JhcHBlciwgLmJ0bi1jbGVhci13cmFwcGVyIHtcbiAgICAgICAgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGFjdGl2ZS10aGVtZS1ncmVlbjtcbiAgICAgICAgICBib3JkZXItY29sb3I6ICRhY3RpdmUtdGhlbWUtZ3JlZW47XG4gICAgICAgIH1cblxuICAgICAgICAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRob3Zlci10aGVtZS1ncmVlbjtcbiAgICAgICAgICBib3JkZXItY29sb3I6ICRob3Zlci10aGVtZS1ncmVlbjtcbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cblxuICAgIEBpZiAkbmFtZSA9PSAnYmx1ZScge1xuICAgICAgLmJ0bi10b2RheS13cmFwcGVyLCAuYnRuLWNsZWFyLXdyYXBwZXIge1xuICAgICAgICAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlIHtcbiAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkYWN0aXZlLXRoZW1lLWJsdWU7XG4gICAgICAgICAgYm9yZGVyLWNvbG9yOiAkYWN0aXZlLXRoZW1lLWJsdWU7XG4gICAgICAgIH1cblxuICAgICAgICAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRob3Zlci10aGVtZS1ibHVlO1xuICAgICAgICAgIGJvcmRlci1jb2xvcjogJGhvdmVyLXRoZW1lLWJsdWU7XG4gICAgICAgIH1cbiAgICAgIH1cbiAgICB9XG5cbiAgICBAaWYgJG5hbWUgPT0gJ2RhcmstYmx1ZScge1xuICAgICAgLmJ0bi10b2RheS13cmFwcGVyLCAuYnRuLWNsZWFyLXdyYXBwZXIge1xuICAgICAgICAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlIHtcbiAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkYWN0aXZlLXRoZW1lLWRhcmstYmx1ZTtcbiAgICAgICAgICBib3JkZXItY29sb3I6ICRhY3RpdmUtdGhlbWUtZGFyay1ibHVlO1xuICAgICAgICB9XG5cbiAgICAgICAgLmJ0bi1zdWNjZXNzOmhvdmVyIHtcbiAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkaG92ZXItdGhlbWUtZGFyay1ibHVlO1xuICAgICAgICAgIGJvcmRlci1jb2xvcjogJGhvdmVyLXRoZW1lLWRhcmstYmx1ZTtcbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cblxuICAgIEBpZiAkbmFtZSA9PSAnb3JhbmdlJyB7XG4gICAgICAuYnRuLXRvZGF5LXdyYXBwZXIsIC5idG4tY2xlYXItd3JhcHBlciB7XG4gICAgICAgIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUge1xuICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRhY3RpdmUtdGhlbWUtb3JhbmdlO1xuICAgICAgICAgIGJvcmRlci1jb2xvcjogJGFjdGl2ZS10aGVtZS1vcmFuZ2U7XG4gICAgICAgIH1cblxuICAgICAgICAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRob3Zlci10aGVtZS1vcmFuZ2U7XG4gICAgICAgICAgYm9yZGVyLWNvbG9yOiAkaG92ZXItdGhlbWUtb3JhbmdlO1xuICAgICAgICB9XG4gICAgICB9XG4gICAgfVxuXG4gICAgQGlmICRuYW1lID09ICdyZWQnIHtcbiAgICAgIC5idG4tdG9kYXktd3JhcHBlciwgLmJ0bi1jbGVhci13cmFwcGVyIHtcbiAgICAgICAgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGFjdGl2ZS10aGVtZS1yZWQ7XG4gICAgICAgICAgYm9yZGVyLWNvbG9yOiAkYWN0aXZlLXRoZW1lLXJlZDtcbiAgICAgICAgfVxuXG4gICAgICAgIC5idG4tc3VjY2Vzczpob3ZlciB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGhvdmVyLXRoZW1lLXJlZDtcbiAgICAgICAgICBib3JkZXItY29sb3I6ICRob3Zlci10aGVtZS1yZWQ7XG4gICAgICAgIH1cbiAgICAgIH1cbiAgICB9XG5cbiAgICBAaWYgJG5hbWUgPT0gJ2RlZmF1bHQnIHtcbiAgICAgIC5idG4tdG9kYXktd3JhcHBlciwgLmJ0bi1jbGVhci13cmFwcGVyIHtcbiAgICAgICAgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGFjdGl2ZS10aGVtZS1kZWZhdWx0O1xuICAgICAgICAgIGJvcmRlci1jb2xvcjogJGFjdGl2ZS10aGVtZS1kZWZhdWx0O1xuICAgICAgICB9XG5cbiAgICAgICAgLmJ0bi1zdWNjZXNzOmhvdmVyIHtcbiAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkaG92ZXItdGhlbWUtZGVmYXVsdDtcbiAgICAgICAgICBib3JkZXItY29sb3I6ICRob3Zlci10aGVtZS1kZWZhdWx0O1xuICAgICAgICB9XG4gICAgICB9XG4gICAgfVxuXG4gICAgICAuYnMtZGF0ZXBpY2tlci1wcmVkZWZpbmVkLWJ0bnMge1xuICAgICAgICBidXR0b24ge1xuICAgICAgICAgICYuc2VsZWN0ZWQge1xuICAgICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGNvbG9yIDtcbiAgICAgICAgICB9XG4gICAgICB9XG4gICAgfVxuXG4gICAgLmJzLWRhdGVwaWNrZXItYm9keSB7XG4gICAgICB0YWJsZSB7XG4gICAgICAgIHRkIHtcbiAgICAgICAgICBzcGFuLnNlbGVjdGVkLFxuICAgICAgICAgICYuc2VsZWN0ZWQgc3BhbixcbiAgICAgICAgICBzcGFuW2NsYXNzKj1cInNlbGVjdC1cIl06YWZ0ZXIsXG4gICAgICAgICAgJltjbGFzcyo9XCJzZWxlY3QtXCJdIHNwYW46YWZ0ZXIge1xuICAgICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogJGNvbG9yO1xuICAgICAgICAgIH1cblxuICAgICAgICAgICYud2VlayBzcGFuIHtcbiAgICAgICAgICAgIGNvbG9yOiAkY29sb3I7XG4gICAgICAgICAgfVxuXG4gICAgICAgICAgJi5hY3RpdmUtd2VlayBzcGFuOmhvdmVyIHtcbiAgICAgICAgICAgIGN1cnNvcjogcG9pbnRlcjtcbiAgICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICRjb2xvcjtcbiAgICAgICAgICAgIGNvbG9yOiAkZm9udC1jb2xvci0wMTtcbiAgICAgICAgICAgIG9wYWNpdHk6IDAuNTtcbiAgICAgICAgICAgIHRyYW5zaXRpb246IDBzO1xuICAgICAgICAgIH1cbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cbiAgfVxufVxuIiwiLyogLmJzLWRhdGVwaWNrZXIgKi9cbi5icy1kYXRlcGlja2VyIHtcbiAgZGlzcGxheTogZmxleDtcbiAgYWxpZ24taXRlbXM6IHN0cmV0Y2g7XG4gIGZsZXgtZmxvdzogcm93IHdyYXA7XG4gIGJhY2tncm91bmQ6ICNmZmY7XG4gIGJveC1zaGFkb3c6IDAgMCAxMHB4IDAgI2FhYTtcbiAgcG9zaXRpb246IHJlbGF0aXZlO1xuICB6LWluZGV4OiAxO1xuICAvKiBidXR0b24gKi9cbiAgLyogLmJzLWRhdGVwaWNrZXItaGVhZCAqL1xuICAvKiAuYnMtZGF0ZXBpY2tlci1ib2R5ICovXG4gIC8qIC5jdXJyZW50LXRpbWVkYXRlICovXG4gIC8qIC5icy1kYXRlcGlja2VyLW11bHRpcGxlICovXG4gIC8qIC5icy1kYXRlcGlja2VyLWJ0bnMgKi9cbiAgLyouYnMtZGF0ZXBpY2tlci1jdXN0b20tcmFuZ2UgKi9cbiAgLyogLmJzLWRhdGVwaWNrZXItcHJlZGVmaW5lZC1idG5zICovXG4gIC8qIC5icy1kYXRlcGlja2VyLWJ1dHRvbnMgKi8gfVxuICAuYnMtZGF0ZXBpY2tlcjphZnRlciB7XG4gICAgY2xlYXI6IGJvdGg7XG4gICAgY29udGVudDogJyc7XG4gICAgZGlzcGxheTogYmxvY2s7IH1cbiAgLmJzLWRhdGVwaWNrZXIgYnMtZGF5LXBpY2tlciB7XG4gICAgZmxvYXQ6IGxlZnQ7IH1cbiAgLmJzLWRhdGVwaWNrZXIgYnV0dG9uOmhvdmVyLFxuICAuYnMtZGF0ZXBpY2tlciBidXR0b246Zm9jdXMsXG4gIC5icy1kYXRlcGlja2VyIGJ1dHRvbjphY3RpdmUsXG4gIC5icy1kYXRlcGlja2VyIGlucHV0OmhvdmVyLFxuICAuYnMtZGF0ZXBpY2tlciBpbnB1dDpmb2N1cyxcbiAgLmJzLWRhdGVwaWNrZXIgaW5wdXQ6YWN0aXZlLFxuICAuYnMtZGF0ZXBpY2tlci1idG5zIGJ1dHRvbjpob3ZlcixcbiAgLmJzLWRhdGVwaWNrZXItYnRucyBidXR0b246Zm9jdXMsXG4gIC5icy1kYXRlcGlja2VyLWJ0bnMgYnV0dG9uOmFjdGl2ZSxcbiAgLmJzLWRhdGVwaWNrZXItcHJlZGVmaW5lZC1idG5zIGJ1dHRvbjphY3RpdmUsXG4gIC5icy1kYXRlcGlja2VyLXByZWRlZmluZWQtYnRucyBidXR0b246Zm9jdXMge1xuICAgIG91dGxpbmU6IG5vbmU7IH1cbiAgLmJzLWRhdGVwaWNrZXItaGVhZCB7XG4gICAgbWluLXdpZHRoOiAyNzBweDtcbiAgICBoZWlnaHQ6IDUwcHg7XG4gICAgcGFkZGluZzogMTBweDtcbiAgICBib3JkZXItcmFkaXVzOiAzcHggM3B4IDAgMDtcbiAgICB0ZXh0LWFsaWduOiBqdXN0aWZ5O1xuICAgIC8qIC5icy1kYXRlcGlja2VyLWhlYWQgYnV0dG9uICovIH1cbiAgICAuYnMtZGF0ZXBpY2tlci1oZWFkOmFmdGVyIHtcbiAgICAgIGNvbnRlbnQ6IFwiXCI7XG4gICAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gICAgICB2ZXJ0aWNhbC1hbGlnbjogdG9wO1xuICAgICAgd2lkdGg6IDEwMCU7IH1cbiAgICAuYnMtZGF0ZXBpY2tlci1oZWFkIGJ1dHRvbiB7XG4gICAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gICAgICB2ZXJ0aWNhbC1hbGlnbjogdG9wO1xuICAgICAgcGFkZGluZzogMDtcbiAgICAgIGhlaWdodDogMzBweDtcbiAgICAgIGxpbmUtaGVpZ2h0OiAzMHB4O1xuICAgICAgYm9yZGVyOiAwO1xuICAgICAgYmFja2dyb3VuZDogdHJhbnNwYXJlbnQ7XG4gICAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XG4gICAgICBjdXJzb3I6IHBvaW50ZXI7XG4gICAgICBjb2xvcjogI2ZmZjtcbiAgICAgIHRyYW5zaXRpb246IDAuM3M7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWhlYWQgYnV0dG9uW2Rpc2FibGVkXSwgLmJzLWRhdGVwaWNrZXItaGVhZCBidXR0b25bZGlzYWJsZWRdOmhvdmVyLCAuYnMtZGF0ZXBpY2tlci1oZWFkIGJ1dHRvbltkaXNhYmxlZF06YWN0aXZlIHtcbiAgICAgICAgYmFja2dyb3VuZDogcmdiYSgyMjEsIDIyMSwgMjIxLCAwLjMpO1xuICAgICAgICBjb2xvcjogI2Y1ZjVmNTtcbiAgICAgICAgY3Vyc29yOiBub3QtYWxsb3dlZDsgfVxuICAgICAgLmJzLWRhdGVwaWNrZXItaGVhZCBidXR0b24ubmV4dCwgLmJzLWRhdGVwaWNrZXItaGVhZCBidXR0b24ucHJldmlvdXMge1xuICAgICAgICBib3JkZXItcmFkaXVzOiA1MCU7XG4gICAgICAgIHdpZHRoOiAzMHB4O1xuICAgICAgICBoZWlnaHQ6IDMwcHg7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItaGVhZCBidXR0b24ubmV4dCBzcGFuLCAuYnMtZGF0ZXBpY2tlci1oZWFkIGJ1dHRvbi5wcmV2aW91cyBzcGFuIHtcbiAgICAgICAgICBmb250LXNpemU6IDI4cHg7XG4gICAgICAgICAgbGluZS1oZWlnaHQ6IDE7XG4gICAgICAgICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICAgICAgICAgIHBvc2l0aW9uOiByZWxhdGl2ZTtcbiAgICAgICAgICBoZWlnaHQ6IDEwMCU7XG4gICAgICAgICAgd2lkdGg6IDEwMCU7XG4gICAgICAgICAgYm9yZGVyLXJhZGl1czogNTAlOyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1oZWFkIGJ1dHRvbi5jdXJyZW50IHtcbiAgICAgICAgYm9yZGVyLXJhZGl1czogMTVweDtcbiAgICAgICAgbWF4LXdpZHRoOiAxNTVweDtcbiAgICAgICAgcGFkZGluZzogMCAxM3B4OyB9XG4gIC5icy1kYXRlcGlja2VyLWhlYWQgYnV0dG9uOmhvdmVyIHtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuMSk7IH1cbiAgLmJzLWRhdGVwaWNrZXItaGVhZCBidXR0b246YWN0aXZlIHtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuMik7IH1cbiAgLmJzLWRhdGVwaWNrZXItYm9keSB7XG4gICAgcGFkZGluZzogMTBweDtcbiAgICBib3JkZXItcmFkaXVzOiAwIDAgM3B4IDNweDtcbiAgICBtaW4taGVpZ2h0OiAyMzJweDtcbiAgICBtaW4td2lkdGg6IDI3OHB4O1xuICAgIGJvcmRlcjogMXB4IHNvbGlkICNlOWVkZjA7XG4gICAgLyogLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSAqLyB9XG4gICAgLmJzLWRhdGVwaWNrZXItYm9keSAuZGF5cy53ZWVrcyB7XG4gICAgICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gICAgICB6LWluZGV4OiAxOyB9XG4gICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB7XG4gICAgICB3aWR0aDogMTAwJTtcbiAgICAgIGJvcmRlci1jb2xsYXBzZTogc2VwYXJhdGU7XG4gICAgICBib3JkZXItc3BhY2luZzogMDtcbiAgICAgIC8qIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyAqL1xuICAgICAgLyogLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZS53ZWVrcyAqLyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRoIHtcbiAgICAgICAgZm9udC1zaXplOiAxM3B4O1xuICAgICAgICBjb2xvcjogIzlhYWVjMTtcbiAgICAgICAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgICAgICAgdGV4dC1hbGlnbjogY2VudGVyOyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHtcbiAgICAgICAgY29sb3I6ICM1NDcwOGI7XG4gICAgICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICAgICAgcG9zaXRpb246IHJlbGF0aXZlO1xuICAgICAgICBwYWRkaW5nOiAwOyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQgc3BhbiB7XG4gICAgICAgICAgZGlzcGxheTogYmxvY2s7XG4gICAgICAgICAgbWFyZ2luOiAwIGF1dG87XG4gICAgICAgICAgZm9udC1zaXplOiAxM3B4O1xuICAgICAgICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICAgICAgICAvKnotaW5kZXg6IDE7Ki9cbiAgICAgICAgICAtbW96LXVzZXItc2VsZWN0OiBub25lO1xuICAgICAgICAgIC13ZWJraXQtdXNlci1zZWxlY3Q6IG5vbmU7XG4gICAgICAgICAgLW1zLXVzZXItc2VsZWN0OiBub25lOyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQ6bm90KC5kaXNhYmxlZCk6bm90KC53ZWVrKSBzcGFuOm5vdCguZGlzYWJsZWQpOm5vdCguaXMtb3RoZXItbW9udGgpIHtcbiAgICAgICAgICBjdXJzb3I6IHBvaW50ZXI7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5pcy1oaWdobGlnaHRlZDpub3QoLmRpc2FibGVkKTpub3QoLnNlbGVjdGVkKSBzcGFuLFxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uaXMtaGlnaGxpZ2h0ZWQ6bm90KC5kaXNhYmxlZCk6bm90KC5zZWxlY3RlZCkge1xuICAgICAgICAgIGJhY2tncm91bmQtY29sb3I6ICNlOWVkZjA7XG4gICAgICAgICAgdHJhbnNpdGlvbjogMHM7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5pcy1hY3RpdmUtb3RoZXItbW9udGg6bm90KC5kaXNhYmxlZCk6bm90KC5zZWxlY3RlZCkgc3BhbixcbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuLmlzLWFjdGl2ZS1vdGhlci1tb250aDpub3QoLmRpc2FibGVkKTpub3QoLnNlbGVjdGVkKSB7XG4gICAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogI2U5ZWRmMDtcbiAgICAgICAgICB0cmFuc2l0aW9uOiAwcztcbiAgICAgICAgICBjdXJzb3I6IHBvaW50ZXI7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuLmRpc2FibGVkLFxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLmRpc2FibGVkIHNwYW4ge1xuICAgICAgICAgIGNvbG9yOiAjOWFhZWMxOyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQgc3Bhbi5zZWxlY3RlZCxcbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5zZWxlY3RlZCBzcGFuIHtcbiAgICAgICAgICBjb2xvcjogI2ZmZjsgfVxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uaXMtb3RoZXItbW9udGgsXG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuaXMtb3RoZXItbW9udGggc3BhbiB7XG4gICAgICAgICAgY29sb3I6IHJnYmEoMCwgMCwgMCwgMC4yNSk7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5hY3RpdmUge1xuICAgICAgICAgIHBvc2l0aW9uOiByZWxhdGl2ZTsgfVxuICAgICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuYWN0aXZlLnNlbGVjdC1zdGFydDpiZWZvcmUge1xuICAgICAgICAgICAgbGVmdDogMzUlOyB9XG4gICAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5hY3RpdmUuc2VsZWN0LWVuZDpiZWZvcmUge1xuICAgICAgICAgICAgbGVmdDogLTg1JTsgfVxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uYWN0aXZlLnNlbGVjdC1zdGFydDphZnRlcixcbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuLmFjdGl2ZS5zZWxlY3QtZW5kOmFmdGVyLFxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLmFjdGl2ZS5zZWxlY3Qtc3RhcnQgc3BhbjphZnRlcixcbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5hY3RpdmUuc2VsZWN0LWVuZCBzcGFuOmFmdGVyIHtcbiAgICAgICAgICBjb250ZW50OiBcIlwiO1xuICAgICAgICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgICAgICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICAgICAgICB6LWluZGV4OiAtMTtcbiAgICAgICAgICB3aWR0aDogMTAwJTtcbiAgICAgICAgICBoZWlnaHQ6IDEwMCU7XG4gICAgICAgICAgdHJhbnNpdGlvbjogMC4zcztcbiAgICAgICAgICB0b3A6IDA7XG4gICAgICAgICAgYm9yZGVyLXJhZGl1czogNTAlOyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQ6YmVmb3JlLFxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW46YmVmb3JlIHtcbiAgICAgICAgICBjb250ZW50OiBcIlwiO1xuICAgICAgICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgICAgICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICAgICAgICB6LWluZGV4OiAtMTtcbiAgICAgICAgICB0b3A6IDZweDtcbiAgICAgICAgICBib3R0b206IDZweDtcbiAgICAgICAgICBsZWZ0OiAtM3B4O1xuICAgICAgICAgIHJpZ2h0OiAtMnB4O1xuICAgICAgICAgIGJveC1zaXppbmc6IGNvbnRlbnQtYm94O1xuICAgICAgICAgIGJhY2tncm91bmQ6IHRyYW5zcGFyZW50OyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuYWN0aXZlLnNlbGVjdC1zdGFydCArIHRkLmFjdGl2ZTpiZWZvcmUge1xuICAgICAgICAgIGxlZnQ6IC0yMCU7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZDpsYXN0LWNoaWxkLmFjdGl2ZTpiZWZvcmUge1xuICAgICAgICAgIGJvcmRlci1yYWRpdXM6IDAgM3B4IDNweCAwO1xuICAgICAgICAgIHdpZHRoOiAxMjUlO1xuICAgICAgICAgIGxlZnQ6IC0yNSU7IH1cbiAgICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuW2NsYXNzKj1cInNlbGVjdC1cIl0sXG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGRbY2xhc3MqPVwic2VsZWN0LVwiXSBzcGFuIHtcbiAgICAgICAgICBib3JkZXItcmFkaXVzOiA1MCU7XG4gICAgICAgICAgY29sb3I6ICNmZmY7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyB0ZC5hY3RpdmU6bm90KC5zZWxlY3Qtc3RhcnQpOmJlZm9yZSwgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZS5kYXlzIHRkLmluLXJhbmdlOm5vdCguc2VsZWN0LXN0YXJ0KTpiZWZvcmUsXG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgc3Bhbi5hY3RpdmU6bm90KC5zZWxlY3Qtc3RhcnQpOmJlZm9yZSxcbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyBzcGFuLmluLXJhbmdlOm5vdCguc2VsZWN0LXN0YXJ0KTpiZWZvcmUge1xuICAgICAgICBiYWNrZ3JvdW5kOiAjZTllZGYwOyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgc3BhbiB7XG4gICAgICAgIHdpZHRoOiAzMnB4O1xuICAgICAgICBoZWlnaHQ6IDMycHg7XG4gICAgICAgIGxpbmUtaGVpZ2h0OiAzMnB4OyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyBzcGFuLnNlbGVjdC1zdGFydCB7XG4gICAgICAgICAgei1pbmRleDogMjsgfVxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgc3Bhbi5pcy1oaWdobGlnaHRlZC5pbi1yYW5nZTpiZWZvcmUge1xuICAgICAgICAgIHJpZ2h0OiAzcHg7XG4gICAgICAgICAgbGVmdDogMDsgfVxuICAgICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgc3Bhbi5pbi1yYW5nZS5zZWxlY3QtZW5kOmJlZm9yZSB7XG4gICAgICAgICAgcmlnaHQ6IDRweDtcbiAgICAgICAgICBsZWZ0OiAwOyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgdGQuc2VsZWN0LXN0YXJ0ICsgdGQuc2VsZWN0LWVuZDpiZWZvcmUsXG4gICAgICAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlLmRheXMgdGQuc2VsZWN0LXN0YXJ0ICsgdGQuaXMtaGlnaGxpZ2h0ZWQ6YmVmb3JlLFxuICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZS5kYXlzIHRkLmFjdGl2ZSArIHRkLmlzLWhpZ2hsaWdodGVkOmJlZm9yZSxcbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyB0ZC5hY3RpdmUgKyB0ZC5zZWxlY3QtZW5kOmJlZm9yZSxcbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyB0ZC5pbi1yYW5nZSArIHRkLmlzLWhpZ2hsaWdodGVkOmJlZm9yZSxcbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUuZGF5cyB0ZC5pbi1yYW5nZSArIHRkLnNlbGVjdC1lbmQ6YmVmb3JlIHtcbiAgICAgICAgYmFja2dyb3VuZDogI2U5ZWRmMDtcbiAgICAgICAgd2lkdGg6IDEwMCU7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUud2Vla3MgdHIgdGQ6bnRoLWNoaWxkKDIpLmFjdGl2ZTpiZWZvcmUge1xuICAgICAgICBib3JkZXItcmFkaXVzOiAzcHggMCAwIDNweDtcbiAgICAgICAgbGVmdDogMDtcbiAgICAgICAgd2lkdGg6IDEwMCU7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGU6bm90KC53ZWVrcykgdHIgdGQ6Zmlyc3QtY2hpbGQ6YmVmb3JlIHtcbiAgICAgICAgYm9yZGVyLXJhZGl1czogM3B4IDAgMCAzcHg7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUueWVhcnMgdGQgc3BhbiB7XG4gICAgICAgIHdpZHRoOiA0NnB4O1xuICAgICAgICBoZWlnaHQ6IDQ2cHg7XG4gICAgICAgIGxpbmUtaGVpZ2h0OiA0NXB4O1xuICAgICAgICBtYXJnaW46IDAgYXV0bzsgfVxuICAgICAgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZS55ZWFycyB0cjpub3QoOmxhc3QtY2hpbGQpIHRkIHNwYW4ge1xuICAgICAgICBtYXJnaW4tYm90dG9tOiA4cHg7IH1cbiAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUubW9udGhzIHRkIHtcbiAgICAgICAgaGVpZ2h0OiA1MnB4OyB9XG4gICAgICAgIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUubW9udGhzIHRkIHNwYW4ge1xuICAgICAgICAgIHBhZGRpbmc6IDZweDtcbiAgICAgICAgICBib3JkZXItcmFkaXVzOiAxNXB4OyB9XG4gIC5icy1kYXRlcGlja2VyIC5jdXJyZW50LXRpbWVkYXRlIHtcbiAgICBjb2xvcjogIzU0NzA4YjtcbiAgICBmb250LXNpemU6IDE1cHg7XG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xuICAgIGhlaWdodDogMzBweDtcbiAgICBsaW5lLWhlaWdodDogMzBweDtcbiAgICBib3JkZXItcmFkaXVzOiAyMHB4O1xuICAgIGJvcmRlcjogMXB4IHNvbGlkICNlOWVkZjA7XG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcbiAgICBjdXJzb3I6IHBvaW50ZXI7XG4gICAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcbiAgICAtbW96LXVzZXItc2VsZWN0OiBub25lO1xuICAgIC13ZWJraXQtdXNlci1zZWxlY3Q6IG5vbmU7XG4gICAgLW1zLXVzZXItc2VsZWN0OiBub25lOyB9XG4gICAgLmJzLWRhdGVwaWNrZXIgLmN1cnJlbnQtdGltZWRhdGUgc3Bhbjpub3QoOmVtcHR5KTpiZWZvcmUge1xuICAgICAgY29udGVudDogXCJcIjtcbiAgICAgIHdpZHRoOiAxNXB4O1xuICAgICAgaGVpZ2h0OiAxNnB4O1xuICAgICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICAgICAgbWFyZ2luLXJpZ2h0OiA0cHg7XG4gICAgICB2ZXJ0aWNhbC1hbGlnbjogdGV4dC1ib3R0b207XG4gICAgICBiYWNrZ3JvdW5kOiB1cmwoZGF0YTppbWFnZS9wbmc7YmFzZTY0LGlWQk9SdzBLR2dvQUFBQU5TVWhFVWdBQUFBOEFBQUFRQ0FZQUFBREpWaVVFQUFBQk1rbEVRVlFvVTlWVHdXM0NRQkNjT1VnQnRFQktTQXVrQW5CS01FK3dGQ0FsWUloazhzUWx4RkFCdEpBU2NBc3VBUEJFZXdZY3hDUDhvdXhyUERzemE2MXVpVk4xbzZSTkhENGh0U0NtcTQ5UmZPNzFCdk1KcUJCa0lUUmYxa21VVzQ5blFSQzloMUk1QVpsQkNsYUw4YVAxZktnT094Q3g4YVNMcytRMTllWnVOTzhRbVBxSlJ0REZndXk3T0FjRGJKUHMrL0JLVlBESVBydkQyWkpnV0FtVmU3TzBySTBWcXMxc2V5V1VYcHVKb3BwWUNhNUwrVSsrTnBOUGtyNU9FMm9NZEFSc2IzZ3lrSlQ1eWRaY0w4WjlXdzYwbnhnMkxoak9OOWxpOU93WFp6byt4TGJwM25DMnM5Q0wyUnJ1ZUd5VnJnd05tOEhwc0N6WjlFRVc2a3FYbG8xR1FlMDNGelAvN1c4SGwwZEJ0dTdCZjd6dDZtSXd2WDFSdnpEQ203K3EzbUFXMERsL0dQZFVDZVhyWkxUOUJyRHJHa200cWxQdkFBQUFBRWxGVGtTdVFtQ0MpOyB9XG4gIC5icy1kYXRlcGlja2VyLW11bHRpcGxlIHtcbiAgICBib3JkZXItcmFkaXVzOiA0cHggMCAwIDRweDsgfVxuICAgIC5icy1kYXRlcGlja2VyLW11bHRpcGxlICsgLmJzLWRhdGVwaWNrZXItbXVsdGlwbGUge1xuICAgICAgbWFyZ2luLWxlZnQ6IDEwcHg7IH1cbiAgICAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSAuYnMtZGF0ZXBpY2tlciB7XG4gICAgICBib3gtc2hhZG93OiBub25lO1xuICAgICAgcG9zaXRpb246IHJlbGF0aXZlOyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSAuYnMtZGF0ZXBpY2tlcjpub3QoOmxhc3QtY2hpbGQpIHtcbiAgICAgICAgcGFkZGluZy1yaWdodDogMTBweDsgfVxuICAgICAgLmJzLWRhdGVwaWNrZXItbXVsdGlwbGUgLmJzLWRhdGVwaWNrZXIgKyAuYnMtZGF0ZXBpY2tlcjphZnRlciB7XG4gICAgICAgIGNvbnRlbnQ6IFwiXCI7XG4gICAgICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgICAgICB3aWR0aDogMTRweDtcbiAgICAgICAgaGVpZ2h0OiAxMHB4O1xuICAgICAgICBiYWNrZ3JvdW5kOiB1cmwoZGF0YTppbWFnZS9wbmc7YmFzZTY0LGlWQk9SdzBLR2dvQUFBQU5TVWhFVWdBQUFBOEFBQUFLQ0FZQUFBQnJHd1Q1QUFBQTFFbEVRVlFvVTQyUnNRckNVQXhGNzdWdUR1N080b01XVy8vQlVSQkJwWnZnS2s0dUlyam9xS09UZitEb3BJTzR1WWdndEZUZnczK3BrUXFDVzEvRzVKN2tKaUZ5NG01TXhVbHhBemdJUEhYK2x6TVB6dXBSWWxZZ3hpUjd2cXNPUDhZS3pzVHgweXhGTUNVWitxN2FaemxyK092Z29XY0FGeUFIZ2F0MmpMV3U0ODI1MkRkcUFpaERKR1NTSk5VVXhZbVFqczMraFBRQmxBaDJyRzJMQ09QbmF3M0lpR0RYOTlUUkNzN0FTSnNOaFVPQTdkL0xjdUh2UkcyMkZJWnZzTlh3MU1YNlZaRXhDaWxPUUtFZmVMWHIvMTArYUM5SG83YXJoN29BQUFBQVNVVk9SSzVDWUlJPSk7XG4gICAgICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICAgICAgdG9wOiAyNXB4O1xuICAgICAgICBsZWZ0OiAtOHB4OyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSAuYnMtZGF0ZXBpY2tlciAubGVmdCB7XG4gICAgICAgIGZsb2F0OiBsZWZ0OyB9XG4gICAgICAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSAuYnMtZGF0ZXBpY2tlciAucmlnaHQge1xuICAgICAgICBmbG9hdDogcmlnaHQ7IH1cbiAgLmJzLWRhdGVwaWNrZXItY29udGFpbmVyIHtcbiAgICBwYWRkaW5nOiAxNXB4OyB9XG4gIC5icy1kYXRlcGlja2VyIC5icy1tZWRpYS1jb250YWluZXIge1xuICAgIGRpc3BsYXk6IGZsZXg7IH1cbiAgICBAbWVkaWEgKG1heC13aWR0aDogNzY4cHgpIHtcbiAgICAgIC5icy1kYXRlcGlja2VyIC5icy1tZWRpYS1jb250YWluZXIge1xuICAgICAgICBmbGV4LWRpcmVjdGlvbjogY29sdW1uOyB9IH1cbiAgLmJzLWRhdGVwaWNrZXItY3VzdG9tLXJhbmdlIHtcbiAgICBwYWRkaW5nOiAxNXB4O1xuICAgIGJhY2tncm91bmQ6ICNlZWU7IH1cbiAgLmJzLWRhdGVwaWNrZXItcHJlZGVmaW5lZC1idG5zIGJ1dHRvbiB7XG4gICAgd2lkdGg6IDEwMCU7XG4gICAgZGlzcGxheTogYmxvY2s7XG4gICAgaGVpZ2h0OiAzMHB4O1xuICAgIGJhY2tncm91bmQtY29sb3I6ICM5YWFlYzE7XG4gICAgYm9yZGVyLXJhZGl1czogNHB4O1xuICAgIGNvbG9yOiAjZmZmO1xuICAgIGJvcmRlcjogMDtcbiAgICBtYXJnaW4tYm90dG9tOiAxMHB4O1xuICAgIHBhZGRpbmc6IDAgMThweDtcbiAgICB0ZXh0LWFsaWduOiBsZWZ0O1xuICAgIHRyYW5zaXRpb246IDAuM3M7IH1cbiAgICAuYnMtZGF0ZXBpY2tlci1wcmVkZWZpbmVkLWJ0bnMgYnV0dG9uOmhvdmVyIHtcbiAgICAgIGJhY2tncm91bmQtY29sb3I6ICM1NDcwOGI7IH1cbiAgLmJzLWRhdGVwaWNrZXItYnV0dG9ucyB7XG4gICAgZGlzcGxheTogZmxleDtcbiAgICBmbGV4LWZsb3c6IHJvdyB3cmFwO1xuICAgIGp1c3RpZnktY29udGVudDogZmxleC1lbmQ7XG4gICAgcGFkZGluZy10b3A6IDEwcHg7XG4gICAgYm9yZGVyLXRvcDogMXB4IHNvbGlkICNlOWVkZjA7IH1cbiAgICAuYnMtZGF0ZXBpY2tlci1idXR0b25zIC5idG4tZGVmYXVsdCB7XG4gICAgICBtYXJnaW4tbGVmdDogMTBweDsgfVxuICAgIC5icy1kYXRlcGlja2VyLWJ1dHRvbnMgLmJ0bi10b2RheS13cmFwcGVyIHtcbiAgICAgIGRpc3BsYXk6IGZsZXg7XG4gICAgICBmbGV4LWZsb3c6IHJvdyB3cmFwOyB9XG4gICAgLmJzLWRhdGVwaWNrZXItYnV0dG9ucyAuY2xlYXItcmlnaHQsXG4gICAgLmJzLWRhdGVwaWNrZXItYnV0dG9ucyAudG9kYXktcmlnaHQge1xuICAgICAgZmxleC1ncm93OiAwOyB9XG4gICAgLmJzLWRhdGVwaWNrZXItYnV0dG9ucyAuY2xlYXItbGVmdCxcbiAgICAuYnMtZGF0ZXBpY2tlci1idXR0b25zIC50b2RheS1sZWZ0IHtcbiAgICAgIGZsZXgtZ3JvdzogMTsgfVxuICAgIC5icy1kYXRlcGlja2VyLWJ1dHRvbnMgLmNsZWFyLWNlbnRlcixcbiAgICAuYnMtZGF0ZXBpY2tlci1idXR0b25zIC50b2RheS1jZW50ZXIge1xuICAgICAgZmxleC1ncm93OiAwLjU7IH1cblxuLyogLmJzLXRpbWVwaWNrZXIgKi9cbi5icy10aW1lcGlja2VyLWNvbnRhaW5lciB7XG4gIHBhZGRpbmc6IDEwcHggMDsgfVxuXG4uYnMtdGltZXBpY2tlci1sYWJlbCB7XG4gIGNvbG9yOiAjNTQ3MDhiO1xuICBtYXJnaW4tYm90dG9tOiAxMHB4OyB9XG5cbi5icy10aW1lcGlja2VyLWNvbnRyb2xzIHtcbiAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICB2ZXJ0aWNhbC1hbGlnbjogdG9wO1xuICBtYXJnaW4tcmlnaHQ6IDEwcHg7IH1cbiAgLmJzLXRpbWVwaWNrZXItY29udHJvbHMgYnV0dG9uIHtcbiAgICB3aWR0aDogMjBweDtcbiAgICBoZWlnaHQ6IDIwcHg7XG4gICAgYm9yZGVyLXJhZGl1czogNTAlO1xuICAgIGJvcmRlcjogMDtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZTllZGYwO1xuICAgIGNvbG9yOiAjNTQ3MDhiO1xuICAgIGZvbnQtc2l6ZTogMTZweDtcbiAgICBmb250LXdlaWdodDogNzAwO1xuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG4gICAgbGluZS1oZWlnaHQ6IDA7XG4gICAgcGFkZGluZzogMDtcbiAgICB0cmFuc2l0aW9uOiAwLjNzOyB9XG4gICAgLmJzLXRpbWVwaWNrZXItY29udHJvbHMgYnV0dG9uOmhvdmVyIHtcbiAgICAgIGJhY2tncm91bmQtY29sb3I6ICNkNWRhZGQ7IH1cbiAgLmJzLXRpbWVwaWNrZXItY29udHJvbHMgaW5wdXQge1xuICAgIHdpZHRoOiAzNXB4O1xuICAgIGhlaWdodDogMjVweDtcbiAgICBib3JkZXItcmFkaXVzOiAxM3B4O1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICBib3JkZXI6IDFweCBzb2xpZCAjZTllZGYwOyB9XG5cbi5icy10aW1lcGlja2VyIC5zd2l0Y2gtdGltZS1mb3JtYXQge1xuICB0ZXh0LXRyYW5zZm9ybTogdXBwZXJjYXNlO1xuICBtaW4td2lkdGg6IDU0cHg7XG4gIGhlaWdodDogMjVweDtcbiAgYm9yZGVyLXJhZGl1czogMjBweDtcbiAgYm9yZGVyOiAxcHggc29saWQgI2U5ZWRmMDtcbiAgYmFja2dyb3VuZDogI2ZmZjtcbiAgY29sb3I6ICM1NDcwOGI7XG4gIGZvbnQtc2l6ZTogMTNweDsgfVxuICAuYnMtdGltZXBpY2tlciAuc3dpdGNoLXRpbWUtZm9ybWF0IGltZyB7XG4gICAgdmVydGljYWwtYWxpZ246IGluaXRpYWw7XG4gICAgbWFyZ2luLWxlZnQ6IDRweDsgfVxuXG5icy1kYXRlcGlja2VyLWNvbnRhaW5lcixcbmJzLWRhdGVyYW5nZXBpY2tlci1jb250YWluZXIge1xuICB6LWluZGV4OiAxMDgwOyB9XG5cbi8qIHNjcmVlbiBzaXplIDwgMTAyNHB4ICovXG5AbWVkaWEgKG1heC13aWR0aDogNzY4cHgpIHtcbiAgLmJzLWRhdGVwaWNrZXItbXVsdGlwbGUge1xuICAgIGRpc3BsYXk6IGZsZXg7IH1cbiAgICAuYnMtZGF0ZXBpY2tlci1tdWx0aXBsZSArIC5icy1kYXRlcGlja2VyLW11bHRpcGxlIHtcbiAgICAgIG1hcmdpbi10b3A6IDEwcHg7XG4gICAgICBtYXJnaW4tbGVmdDogMDsgfSB9XG5cbi8qIHRoZW1pbmcgKi9cbi50aGVtZS1kZWZhdWx0IC5icy1kYXRlcGlja2VyLWhlYWQge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNzc3OyB9XG5cbi50aGVtZS1kZWZhdWx0IC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3MsIC50aGVtZS1kZWZhdWx0IC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3Mge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNzc3O1xuICBib3JkZXItY29sb3I6ICM3Nzc7IH1cblxuLnRoZW1lLWRlZmF1bHQgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmU6Zm9jdXMsIC50aGVtZS1kZWZhdWx0IC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlOmZvY3VzIHtcbiAgYm94LXNoYWRvdzogbm9uZTsgfVxuXG4udGhlbWUtZGVmYXVsdCAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmZvY3VzLCAudGhlbWUtZGVmYXVsdCAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmZvY3VzIHtcbiAgYm94LXNoYWRvdzogbm9uZTsgfVxuXG4udGhlbWUtZGVmYXVsdCAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSwgLnRoZW1lLWRlZmF1bHQgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNjE2MTYxO1xuICBib3JkZXItY29sb3I6ICM2MTYxNjE7IH1cblxuLnRoZW1lLWRlZmF1bHQgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpob3ZlciwgLnRoZW1lLWRlZmF1bHQgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpob3ZlciB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM2RjZFNkU7XG4gIGJvcmRlci1jb2xvcjogIzZGNkU2RTsgfVxuXG4udGhlbWUtZGVmYXVsdCAuYnMtZGF0ZXBpY2tlci1wcmVkZWZpbmVkLWJ0bnMgYnV0dG9uLnNlbGVjdGVkIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzc3NzsgfVxuXG4udGhlbWUtZGVmYXVsdCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uc2VsZWN0ZWQsXG4udGhlbWUtZGVmYXVsdCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLnNlbGVjdGVkIHNwYW4sXG4udGhlbWUtZGVmYXVsdCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW5bY2xhc3MqPVwic2VsZWN0LVwiXTphZnRlcixcbi50aGVtZS1kZWZhdWx0IC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGRbY2xhc3MqPVwic2VsZWN0LVwiXSBzcGFuOmFmdGVyIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzc3NzsgfVxuXG4udGhlbWUtZGVmYXVsdCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLndlZWsgc3BhbiB7XG4gIGNvbG9yOiAjNzc3OyB9XG5cbi50aGVtZS1kZWZhdWx0IC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuYWN0aXZlLXdlZWsgc3Bhbjpob3ZlciB7XG4gIGN1cnNvcjogcG9pbnRlcjtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzc3NztcbiAgY29sb3I6ICNmZmY7XG4gIG9wYWNpdHk6IDAuNTtcbiAgdHJhbnNpdGlvbjogMHM7IH1cblxuLnRoZW1lLWdyZWVuIC5icy1kYXRlcGlja2VyLWhlYWQge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNWNiODVjOyB9XG5cbi50aGVtZS1ncmVlbiAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzLCAudGhlbWUtZ3JlZW4gLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2VzcyB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1Y2I4NWM7XG4gIGJvcmRlci1jb2xvcjogIzVjYjg1YzsgfVxuXG4udGhlbWUtZ3JlZW4gLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmU6Zm9jdXMsIC50aGVtZS1ncmVlbiAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZTpmb2N1cyB7XG4gIGJveC1zaGFkb3c6IG5vbmU7IH1cblxuLnRoZW1lLWdyZWVuIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6Zm9jdXMsIC50aGVtZS1ncmVlbiAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmZvY3VzIHtcbiAgYm94LXNoYWRvdzogbm9uZTsgfVxuXG4udGhlbWUtZ3JlZW4gLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUsIC50aGVtZS1ncmVlbiAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMxZTdlMzQ7XG4gIGJvcmRlci1jb2xvcjogIzFlN2UzNDsgfVxuXG4udGhlbWUtZ3JlZW4gLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpob3ZlciwgLnRoZW1lLWdyZWVuIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMjE4ODM4O1xuICBib3JkZXItY29sb3I6ICMyMTg4Mzg7IH1cblxuLnRoZW1lLWdyZWVuIC5icy1kYXRlcGlja2VyLXByZWRlZmluZWQtYnRucyBidXR0b24uc2VsZWN0ZWQge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNWNiODVjOyB9XG5cbi50aGVtZS1ncmVlbiAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uc2VsZWN0ZWQsXG4udGhlbWUtZ3JlZW4gLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5zZWxlY3RlZCBzcGFuLFxuLnRoZW1lLWdyZWVuIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQgc3BhbltjbGFzcyo9XCJzZWxlY3QtXCJdOmFmdGVyLFxuLnRoZW1lLWdyZWVuIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGRbY2xhc3MqPVwic2VsZWN0LVwiXSBzcGFuOmFmdGVyIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzVjYjg1YzsgfVxuXG4udGhlbWUtZ3JlZW4gLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC53ZWVrIHNwYW4ge1xuICBjb2xvcjogIzVjYjg1YzsgfVxuXG4udGhlbWUtZ3JlZW4gLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5hY3RpdmUtd2VlayBzcGFuOmhvdmVyIHtcbiAgY3Vyc29yOiBwb2ludGVyO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNWNiODVjO1xuICBjb2xvcjogI2ZmZjtcbiAgb3BhY2l0eTogMC41O1xuICB0cmFuc2l0aW9uOiAwczsgfVxuXG4udGhlbWUtYmx1ZSAuYnMtZGF0ZXBpY2tlci1oZWFkIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzViYzBkZTsgfVxuXG4udGhlbWUtYmx1ZSAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzLCAudGhlbWUtYmx1ZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzViYzBkZTtcbiAgYm9yZGVyLWNvbG9yOiAjNWJjMGRlOyB9XG5cbi50aGVtZS1ibHVlIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlOmZvY3VzLCAudGhlbWUtYmx1ZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZTpmb2N1cyB7XG4gIGJveC1zaGFkb3c6IG5vbmU7IH1cblxuLnRoZW1lLWJsdWUgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpmb2N1cywgLnRoZW1lLWJsdWUgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpmb2N1cyB7XG4gIGJveC1zaGFkb3c6IG5vbmU7IH1cblxuLnRoZW1lLWJsdWUgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUsIC50aGVtZS1ibHVlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzJBQThDRDtcbiAgYm9yZGVyLWNvbG9yOiAjMkFBOENEOyB9XG5cbi50aGVtZS1ibHVlIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6aG92ZXIsIC50aGVtZS1ibHVlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjM0FCM0Q3O1xuICBib3JkZXItY29sb3I6ICMzQUIzRDc7IH1cblxuLnRoZW1lLWJsdWUgLmJzLWRhdGVwaWNrZXItcHJlZGVmaW5lZC1idG5zIGJ1dHRvbi5zZWxlY3RlZCB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1YmMwZGU7IH1cblxuLnRoZW1lLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuLnNlbGVjdGVkLFxuLnRoZW1lLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5zZWxlY3RlZCBzcGFuLFxuLnRoZW1lLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuW2NsYXNzKj1cInNlbGVjdC1cIl06YWZ0ZXIsXG4udGhlbWUtYmx1ZSAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkW2NsYXNzKj1cInNlbGVjdC1cIl0gc3BhbjphZnRlciB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1YmMwZGU7IH1cblxuLnRoZW1lLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC53ZWVrIHNwYW4ge1xuICBjb2xvcjogIzViYzBkZTsgfVxuXG4udGhlbWUtYmx1ZSAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLmFjdGl2ZS13ZWVrIHNwYW46aG92ZXIge1xuICBjdXJzb3I6IHBvaW50ZXI7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1YmMwZGU7XG4gIGNvbG9yOiAjZmZmO1xuICBvcGFjaXR5OiAwLjU7XG4gIHRyYW5zaXRpb246IDBzOyB9XG5cbi50aGVtZS1kYXJrLWJsdWUgLmJzLWRhdGVwaWNrZXItaGVhZCB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMzMzdhYjc7IH1cblxuLnRoZW1lLWRhcmstYmx1ZSAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzLCAudGhlbWUtZGFyay1ibHVlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3Mge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMzM3YWI3O1xuICBib3JkZXItY29sb3I6ICMzMzdhYjc7IH1cblxuLnRoZW1lLWRhcmstYmx1ZSAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZTpmb2N1cywgLnRoZW1lLWRhcmstYmx1ZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZTpmb2N1cyB7XG4gIGJveC1zaGFkb3c6IG5vbmU7IH1cblxuLnRoZW1lLWRhcmstYmx1ZSAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmZvY3VzLCAudGhlbWUtZGFyay1ibHVlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6Zm9jdXMge1xuICBib3gtc2hhZG93OiBub25lOyB9XG5cbi50aGVtZS1kYXJrLWJsdWUgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUsIC50aGVtZS1kYXJrLWJsdWUgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmUge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMjY2NDk4O1xuICBib3JkZXItY29sb3I6ICMyNjY0OTg7IH1cblxuLnRoZW1lLWRhcmstYmx1ZSAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmhvdmVyLCAudGhlbWUtZGFyay1ibHVlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6aG92ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMkM2RkE5O1xuICBib3JkZXItY29sb3I6ICMyQzZGQTk7IH1cblxuLnRoZW1lLWRhcmstYmx1ZSAuYnMtZGF0ZXBpY2tlci1wcmVkZWZpbmVkLWJ0bnMgYnV0dG9uLnNlbGVjdGVkIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzMzN2FiNzsgfVxuXG4udGhlbWUtZGFyay1ibHVlIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQgc3Bhbi5zZWxlY3RlZCxcbi50aGVtZS1kYXJrLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5zZWxlY3RlZCBzcGFuLFxuLnRoZW1lLWRhcmstYmx1ZSAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW5bY2xhc3MqPVwic2VsZWN0LVwiXTphZnRlcixcbi50aGVtZS1kYXJrLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZFtjbGFzcyo9XCJzZWxlY3QtXCJdIHNwYW46YWZ0ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMzM3YWI3OyB9XG5cbi50aGVtZS1kYXJrLWJsdWUgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC53ZWVrIHNwYW4ge1xuICBjb2xvcjogIzMzN2FiNzsgfVxuXG4udGhlbWUtZGFyay1ibHVlIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuYWN0aXZlLXdlZWsgc3Bhbjpob3ZlciB7XG4gIGN1cnNvcjogcG9pbnRlcjtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzMzN2FiNztcbiAgY29sb3I6ICNmZmY7XG4gIG9wYWNpdHk6IDAuNTtcbiAgdHJhbnNpdGlvbjogMHM7IH1cblxuLnRoZW1lLXJlZCAuYnMtZGF0ZXBpY2tlci1oZWFkIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2Q5NTM0ZjsgfVxuXG4udGhlbWUtcmVkIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3MsIC50aGVtZS1yZWQgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2VzcyB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNkOTUzNGY7XG4gIGJvcmRlci1jb2xvcjogI2Q5NTM0ZjsgfVxuXG4udGhlbWUtcmVkIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlOmZvY3VzLCAudGhlbWUtcmVkIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlOmZvY3VzIHtcbiAgYm94LXNoYWRvdzogbm9uZTsgfVxuXG4udGhlbWUtcmVkIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6Zm9jdXMsIC50aGVtZS1yZWQgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpmb2N1cyB7XG4gIGJveC1zaGFkb3c6IG5vbmU7IH1cblxuLnRoZW1lLXJlZCAuYnRuLXRvZGF5LXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSwgLnRoZW1lLXJlZCAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOm5vdCg6ZGlzYWJsZWQpOm5vdCguZGlzYWJsZWQpOmFjdGl2ZSB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNEMjM1MzE7XG4gIGJvcmRlci1jb2xvcjogI0QyMzUzMTsgfVxuXG4udGhlbWUtcmVkIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6aG92ZXIsIC50aGVtZS1yZWQgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpob3ZlciB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNFMzM3MzI7XG4gIGJvcmRlci1jb2xvcjogI0UzMzczMjsgfVxuXG4udGhlbWUtcmVkIC5icy1kYXRlcGlja2VyLXByZWRlZmluZWQtYnRucyBidXR0b24uc2VsZWN0ZWQge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZDk1MzRmOyB9XG5cbi50aGVtZS1yZWQgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuLnNlbGVjdGVkLFxuLnRoZW1lLXJlZCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLnNlbGVjdGVkIHNwYW4sXG4udGhlbWUtcmVkIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQgc3BhbltjbGFzcyo9XCJzZWxlY3QtXCJdOmFmdGVyLFxuLnRoZW1lLXJlZCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkW2NsYXNzKj1cInNlbGVjdC1cIl0gc3BhbjphZnRlciB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNkOTUzNGY7IH1cblxuLnRoZW1lLXJlZCAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLndlZWsgc3BhbiB7XG4gIGNvbG9yOiAjZDk1MzRmOyB9XG5cbi50aGVtZS1yZWQgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZC5hY3RpdmUtd2VlayBzcGFuOmhvdmVyIHtcbiAgY3Vyc29yOiBwb2ludGVyO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZDk1MzRmO1xuICBjb2xvcjogI2ZmZjtcbiAgb3BhY2l0eTogMC41O1xuICB0cmFuc2l0aW9uOiAwczsgfVxuXG4udGhlbWUtb3JhbmdlIC5icy1kYXRlcGlja2VyLWhlYWQge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZjBhZDRlOyB9XG5cbi50aGVtZS1vcmFuZ2UgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2VzcywgLnRoZW1lLW9yYW5nZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2YwYWQ0ZTtcbiAgYm9yZGVyLWNvbG9yOiAjZjBhZDRlOyB9XG5cbi50aGVtZS1vcmFuZ2UgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmU6Zm9jdXMsIC50aGVtZS1vcmFuZ2UgLmJ0bi1jbGVhci13cmFwcGVyIC5idG4tc3VjY2Vzczpub3QoOmRpc2FibGVkKTpub3QoLmRpc2FibGVkKTphY3RpdmU6Zm9jdXMge1xuICBib3gtc2hhZG93OiBub25lOyB9XG5cbi50aGVtZS1vcmFuZ2UgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpmb2N1cywgLnRoZW1lLW9yYW5nZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmZvY3VzIHtcbiAgYm94LXNoYWRvdzogbm9uZTsgfVxuXG4udGhlbWUtb3JhbmdlIC5idG4tdG9kYXktd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlLCAudGhlbWUtb3JhbmdlIC5idG4tY2xlYXItd3JhcHBlciAuYnRuLXN1Y2Nlc3M6bm90KDpkaXNhYmxlZCk6bm90KC5kaXNhYmxlZCk6YWN0aXZlIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI0VEOUMyOTtcbiAgYm9yZGVyLWNvbG9yOiAjRUQ5QzI5OyB9XG5cbi50aGVtZS1vcmFuZ2UgLmJ0bi10b2RheS13cmFwcGVyIC5idG4tc3VjY2Vzczpob3ZlciwgLnRoZW1lLW9yYW5nZSAuYnRuLWNsZWFyLXdyYXBwZXIgLmJ0bi1zdWNjZXNzOmhvdmVyIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI0ZGQUMzNTtcbiAgYm9yZGVyLWNvbG9yOiAjRkZBQzM1OyB9XG5cbi50aGVtZS1vcmFuZ2UgLmJzLWRhdGVwaWNrZXItcHJlZGVmaW5lZC1idG5zIGJ1dHRvbi5zZWxlY3RlZCB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNmMGFkNGU7IH1cblxuLnRoZW1lLW9yYW5nZSAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkIHNwYW4uc2VsZWN0ZWQsXG4udGhlbWUtb3JhbmdlIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQuc2VsZWN0ZWQgc3Bhbixcbi50aGVtZS1vcmFuZ2UgLmJzLWRhdGVwaWNrZXItYm9keSB0YWJsZSB0ZCBzcGFuW2NsYXNzKj1cInNlbGVjdC1cIl06YWZ0ZXIsXG4udGhlbWUtb3JhbmdlIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGRbY2xhc3MqPVwic2VsZWN0LVwiXSBzcGFuOmFmdGVyIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2YwYWQ0ZTsgfVxuXG4udGhlbWUtb3JhbmdlIC5icy1kYXRlcGlja2VyLWJvZHkgdGFibGUgdGQud2VlayBzcGFuIHtcbiAgY29sb3I6ICNmMGFkNGU7IH1cblxuLnRoZW1lLW9yYW5nZSAuYnMtZGF0ZXBpY2tlci1ib2R5IHRhYmxlIHRkLmFjdGl2ZS13ZWVrIHNwYW46aG92ZXIge1xuICBjdXJzb3I6IHBvaW50ZXI7XG4gIGJhY2tncm91bmQtY29sb3I6ICNmMGFkNGU7XG4gIGNvbG9yOiAjZmZmO1xuICBvcGFjaXR5OiAwLjU7XG4gIHRyYW5zaXRpb246IDBzOyB9XG5cbi8qIyBzb3VyY2VNYXBwaW5nVVJMPWJzLWRhdGVwaWNrZXIuY3NzLm1hcCAqLyJdfQ== */", '', '']]

/***/ }),

/***/ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./src/styles.css":
/*!*****************************************************************************************************************************************************************!*\
  !*** ./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src??embedded!./src/styles.css ***!
  \*****************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {


/***/ }),

/***/ "./node_modules/bootstrap/dist/css/bootstrap.min.css":
/*!***********************************************************!*\
  !*** ./node_modules/bootstrap/dist/css/bootstrap.min.css ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {


var content = __webpack_require__(/*! !../../../@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!../../../postcss-loader/src??embedded!./bootstrap.min.css */ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./node_modules/bootstrap/dist/css/bootstrap.min.css");

if(typeof content === 'string') content = [[module.i, content, '']];

var transform;
var insertInto;



var options = {"hmr":true}

options.transform = transform
options.insertInto = undefined;

var update = __webpack_require__(/*! ../../../style-loader/lib/addStyles.js */ "./node_modules/style-loader/lib/addStyles.js")(content, options);

if(content.locals) module.exports = content.locals;

if(false) {}

/***/ }),

/***/ "./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css":
/*!*****************************************************************!*\
  !*** ./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {


var content = __webpack_require__(/*! !../../@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!../../postcss-loader/src??embedded!./bs-datepicker.css */ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css");

if(typeof content === 'string') content = [[module.i, content, '']];

var transform;
var insertInto;



var options = {"hmr":true}

options.transform = transform
options.insertInto = undefined;

var update = __webpack_require__(/*! ../../style-loader/lib/addStyles.js */ "./node_modules/style-loader/lib/addStyles.js")(content, options);

if(content.locals) module.exports = content.locals;

if(false) {}

/***/ }),

/***/ "./node_modules/style-loader/lib/addStyles.js":
/*!****************************************************!*\
  !*** ./node_modules/style-loader/lib/addStyles.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

/*
	MIT License http://www.opensource.org/licenses/mit-license.php
	Author Tobias Koppers @sokra
*/

var stylesInDom = {};

var	memoize = function (fn) {
	var memo;

	return function () {
		if (typeof memo === "undefined") memo = fn.apply(this, arguments);
		return memo;
	};
};

var isOldIE = memoize(function () {
	// Test for IE <= 9 as proposed by Browserhacks
	// @see http://browserhacks.com/#hack-e71d8692f65334173fee715c222cb805
	// Tests for existence of standard globals is to allow style-loader
	// to operate correctly into non-standard environments
	// @see https://github.com/webpack-contrib/style-loader/issues/177
	return window && document && document.all && !window.atob;
});

var getTarget = function (target, parent) {
  if (parent){
    return parent.querySelector(target);
  }
  return document.querySelector(target);
};

var getElement = (function (fn) {
	var memo = {};

	return function(target, parent) {
                // If passing function in options, then use it for resolve "head" element.
                // Useful for Shadow Root style i.e
                // {
                //   insertInto: function () { return document.querySelector("#foo").shadowRoot }
                // }
                if (typeof target === 'function') {
                        return target();
                }
                if (typeof memo[target] === "undefined") {
			var styleTarget = getTarget.call(this, target, parent);
			// Special case to return head of iframe instead of iframe itself
			if (window.HTMLIFrameElement && styleTarget instanceof window.HTMLIFrameElement) {
				try {
					// This will throw an exception if access to iframe is blocked
					// due to cross-origin restrictions
					styleTarget = styleTarget.contentDocument.head;
				} catch(e) {
					styleTarget = null;
				}
			}
			memo[target] = styleTarget;
		}
		return memo[target]
	};
})();

var singleton = null;
var	singletonCounter = 0;
var	stylesInsertedAtTop = [];

var	fixUrls = __webpack_require__(/*! ./urls */ "./node_modules/style-loader/lib/urls.js");

module.exports = function(list, options) {
	if (typeof DEBUG !== "undefined" && DEBUG) {
		if (typeof document !== "object") throw new Error("The style-loader cannot be used in a non-browser environment");
	}

	options = options || {};

	options.attrs = typeof options.attrs === "object" ? options.attrs : {};

	// Force single-tag solution on IE6-9, which has a hard limit on the # of <style>
	// tags it will allow on a page
	if (!options.singleton && typeof options.singleton !== "boolean") options.singleton = isOldIE();

	// By default, add <style> tags to the <head> element
        if (!options.insertInto) options.insertInto = "head";

	// By default, add <style> tags to the bottom of the target
	if (!options.insertAt) options.insertAt = "bottom";

	var styles = listToStyles(list, options);

	addStylesToDom(styles, options);

	return function update (newList) {
		var mayRemove = [];

		for (var i = 0; i < styles.length; i++) {
			var item = styles[i];
			var domStyle = stylesInDom[item.id];

			domStyle.refs--;
			mayRemove.push(domStyle);
		}

		if(newList) {
			var newStyles = listToStyles(newList, options);
			addStylesToDom(newStyles, options);
		}

		for (var i = 0; i < mayRemove.length; i++) {
			var domStyle = mayRemove[i];

			if(domStyle.refs === 0) {
				for (var j = 0; j < domStyle.parts.length; j++) domStyle.parts[j]();

				delete stylesInDom[domStyle.id];
			}
		}
	};
};

function addStylesToDom (styles, options) {
	for (var i = 0; i < styles.length; i++) {
		var item = styles[i];
		var domStyle = stylesInDom[item.id];

		if(domStyle) {
			domStyle.refs++;

			for(var j = 0; j < domStyle.parts.length; j++) {
				domStyle.parts[j](item.parts[j]);
			}

			for(; j < item.parts.length; j++) {
				domStyle.parts.push(addStyle(item.parts[j], options));
			}
		} else {
			var parts = [];

			for(var j = 0; j < item.parts.length; j++) {
				parts.push(addStyle(item.parts[j], options));
			}

			stylesInDom[item.id] = {id: item.id, refs: 1, parts: parts};
		}
	}
}

function listToStyles (list, options) {
	var styles = [];
	var newStyles = {};

	for (var i = 0; i < list.length; i++) {
		var item = list[i];
		var id = options.base ? item[0] + options.base : item[0];
		var css = item[1];
		var media = item[2];
		var sourceMap = item[3];
		var part = {css: css, media: media, sourceMap: sourceMap};

		if(!newStyles[id]) styles.push(newStyles[id] = {id: id, parts: [part]});
		else newStyles[id].parts.push(part);
	}

	return styles;
}

function insertStyleElement (options, style) {
	var target = getElement(options.insertInto)

	if (!target) {
		throw new Error("Couldn't find a style target. This probably means that the value for the 'insertInto' parameter is invalid.");
	}

	var lastStyleElementInsertedAtTop = stylesInsertedAtTop[stylesInsertedAtTop.length - 1];

	if (options.insertAt === "top") {
		if (!lastStyleElementInsertedAtTop) {
			target.insertBefore(style, target.firstChild);
		} else if (lastStyleElementInsertedAtTop.nextSibling) {
			target.insertBefore(style, lastStyleElementInsertedAtTop.nextSibling);
		} else {
			target.appendChild(style);
		}
		stylesInsertedAtTop.push(style);
	} else if (options.insertAt === "bottom") {
		target.appendChild(style);
	} else if (typeof options.insertAt === "object" && options.insertAt.before) {
		var nextSibling = getElement(options.insertAt.before, target);
		target.insertBefore(style, nextSibling);
	} else {
		throw new Error("[Style Loader]\n\n Invalid value for parameter 'insertAt' ('options.insertAt') found.\n Must be 'top', 'bottom', or Object.\n (https://github.com/webpack-contrib/style-loader#insertat)\n");
	}
}

function removeStyleElement (style) {
	if (style.parentNode === null) return false;
	style.parentNode.removeChild(style);

	var idx = stylesInsertedAtTop.indexOf(style);
	if(idx >= 0) {
		stylesInsertedAtTop.splice(idx, 1);
	}
}

function createStyleElement (options) {
	var style = document.createElement("style");

	if(options.attrs.type === undefined) {
		options.attrs.type = "text/css";
	}

	if(options.attrs.nonce === undefined) {
		var nonce = getNonce();
		if (nonce) {
			options.attrs.nonce = nonce;
		}
	}

	addAttrs(style, options.attrs);
	insertStyleElement(options, style);

	return style;
}

function createLinkElement (options) {
	var link = document.createElement("link");

	if(options.attrs.type === undefined) {
		options.attrs.type = "text/css";
	}
	options.attrs.rel = "stylesheet";

	addAttrs(link, options.attrs);
	insertStyleElement(options, link);

	return link;
}

function addAttrs (el, attrs) {
	Object.keys(attrs).forEach(function (key) {
		el.setAttribute(key, attrs[key]);
	});
}

function getNonce() {
	if (false) {}

	return __webpack_require__.nc;
}

function addStyle (obj, options) {
	var style, update, remove, result;

	// If a transform function was defined, run it on the css
	if (options.transform && obj.css) {
	    result = typeof options.transform === 'function'
		 ? options.transform(obj.css) 
		 : options.transform.default(obj.css);

	    if (result) {
	    	// If transform returns a value, use that instead of the original css.
	    	// This allows running runtime transformations on the css.
	    	obj.css = result;
	    } else {
	    	// If the transform function returns a falsy value, don't add this css.
	    	// This allows conditional loading of css
	    	return function() {
	    		// noop
	    	};
	    }
	}

	if (options.singleton) {
		var styleIndex = singletonCounter++;

		style = singleton || (singleton = createStyleElement(options));

		update = applyToSingletonTag.bind(null, style, styleIndex, false);
		remove = applyToSingletonTag.bind(null, style, styleIndex, true);

	} else if (
		obj.sourceMap &&
		typeof URL === "function" &&
		typeof URL.createObjectURL === "function" &&
		typeof URL.revokeObjectURL === "function" &&
		typeof Blob === "function" &&
		typeof btoa === "function"
	) {
		style = createLinkElement(options);
		update = updateLink.bind(null, style, options);
		remove = function () {
			removeStyleElement(style);

			if(style.href) URL.revokeObjectURL(style.href);
		};
	} else {
		style = createStyleElement(options);
		update = applyToTag.bind(null, style);
		remove = function () {
			removeStyleElement(style);
		};
	}

	update(obj);

	return function updateStyle (newObj) {
		if (newObj) {
			if (
				newObj.css === obj.css &&
				newObj.media === obj.media &&
				newObj.sourceMap === obj.sourceMap
			) {
				return;
			}

			update(obj = newObj);
		} else {
			remove();
		}
	};
}

var replaceText = (function () {
	var textStore = [];

	return function (index, replacement) {
		textStore[index] = replacement;

		return textStore.filter(Boolean).join('\n');
	};
})();

function applyToSingletonTag (style, index, remove, obj) {
	var css = remove ? "" : obj.css;

	if (style.styleSheet) {
		style.styleSheet.cssText = replaceText(index, css);
	} else {
		var cssNode = document.createTextNode(css);
		var childNodes = style.childNodes;

		if (childNodes[index]) style.removeChild(childNodes[index]);

		if (childNodes.length) {
			style.insertBefore(cssNode, childNodes[index]);
		} else {
			style.appendChild(cssNode);
		}
	}
}

function applyToTag (style, obj) {
	var css = obj.css;
	var media = obj.media;

	if(media) {
		style.setAttribute("media", media)
	}

	if(style.styleSheet) {
		style.styleSheet.cssText = css;
	} else {
		while(style.firstChild) {
			style.removeChild(style.firstChild);
		}

		style.appendChild(document.createTextNode(css));
	}
}

function updateLink (link, options, obj) {
	var css = obj.css;
	var sourceMap = obj.sourceMap;

	/*
		If convertToAbsoluteUrls isn't defined, but sourcemaps are enabled
		and there is no publicPath defined then lets turn convertToAbsoluteUrls
		on by default.  Otherwise default to the convertToAbsoluteUrls option
		directly
	*/
	var autoFixUrls = options.convertToAbsoluteUrls === undefined && sourceMap;

	if (options.convertToAbsoluteUrls || autoFixUrls) {
		css = fixUrls(css);
	}

	if (sourceMap) {
		// http://stackoverflow.com/a/26603875
		css += "\n/*# sourceMappingURL=data:application/json;base64," + btoa(unescape(encodeURIComponent(JSON.stringify(sourceMap)))) + " */";
	}

	var blob = new Blob([css], { type: "text/css" });

	var oldSrc = link.href;

	link.href = URL.createObjectURL(blob);

	if(oldSrc) URL.revokeObjectURL(oldSrc);
}


/***/ }),

/***/ "./node_modules/style-loader/lib/urls.js":
/*!***********************************************!*\
  !*** ./node_modules/style-loader/lib/urls.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {


/**
 * When source maps are enabled, `style-loader` uses a link element with a data-uri to
 * embed the css on the page. This breaks all relative urls because now they are relative to a
 * bundle instead of the current page.
 *
 * One solution is to only use full urls, but that may be impossible.
 *
 * Instead, this function "fixes" the relative urls to be absolute according to the current page location.
 *
 * A rudimentary test suite is located at `test/fixUrls.js` and can be run via the `npm test` command.
 *
 */

module.exports = function (css) {
  // get current location
  var location = typeof window !== "undefined" && window.location;

  if (!location) {
    throw new Error("fixUrls requires window.location");
  }

	// blank or null?
	if (!css || typeof css !== "string") {
	  return css;
  }

  var baseUrl = location.protocol + "//" + location.host;
  var currentDir = baseUrl + location.pathname.replace(/\/[^\/]*$/, "/");

	// convert each url(...)
	/*
	This regular expression is just a way to recursively match brackets within
	a string.

	 /url\s*\(  = Match on the word "url" with any whitespace after it and then a parens
	   (  = Start a capturing group
	     (?:  = Start a non-capturing group
	         [^)(]  = Match anything that isn't a parentheses
	         |  = OR
	         \(  = Match a start parentheses
	             (?:  = Start another non-capturing groups
	                 [^)(]+  = Match anything that isn't a parentheses
	                 |  = OR
	                 \(  = Match a start parentheses
	                     [^)(]*  = Match anything that isn't a parentheses
	                 \)  = Match a end parentheses
	             )  = End Group
              *\) = Match anything and then a close parens
          )  = Close non-capturing group
          *  = Match anything
       )  = Close capturing group
	 \)  = Match a close parens

	 /gi  = Get all matches, not the first.  Be case insensitive.
	 */
	var fixedCss = css.replace(/url\s*\(((?:[^)(]|\((?:[^)(]+|\([^)(]*\))*\))*)\)/gi, function(fullMatch, origUrl) {
		// strip quotes (if they exist)
		var unquotedOrigUrl = origUrl
			.trim()
			.replace(/^"(.*)"$/, function(o, $1){ return $1; })
			.replace(/^'(.*)'$/, function(o, $1){ return $1; });

		// already a full url? no change
		if (/^(#|data:|http:\/\/|https:\/\/|file:\/\/\/|\s*$)/i.test(unquotedOrigUrl)) {
		  return fullMatch;
		}

		// convert the url to a full url
		var newUrl;

		if (unquotedOrigUrl.indexOf("//") === 0) {
		  	//TODO: should we add protocol?
			newUrl = unquotedOrigUrl;
		} else if (unquotedOrigUrl.indexOf("/") === 0) {
			// path should be relative to the base url
			newUrl = baseUrl + unquotedOrigUrl; // already starts with '/'
		} else {
			// path should be relative to current directory
			newUrl = currentDir + unquotedOrigUrl.replace(/^\.\//, ""); // Strip leading './'
		}

		// send back the fixed url(...)
		return "url(" + JSON.stringify(newUrl) + ")";
	});

	// send back the fixed css
	return fixedCss;
};


/***/ }),

/***/ "./src/styles.css":
/*!************************!*\
  !*** ./src/styles.css ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {


var content = __webpack_require__(/*! !../node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!../node_modules/postcss-loader/src??embedded!./styles.css */ "./node_modules/@angular-devkit/build-angular/src/angular-cli-files/plugins/raw-css-loader.js!./node_modules/postcss-loader/src/index.js?!./src/styles.css");

if(typeof content === 'string') content = [[module.i, content, '']];

var transform;
var insertInto;



var options = {"hmr":true}

options.transform = transform
options.insertInto = undefined;

var update = __webpack_require__(/*! ../node_modules/style-loader/lib/addStyles.js */ "./node_modules/style-loader/lib/addStyles.js")(content, options);

if(content.locals) module.exports = content.locals;

if(false) {}

/***/ }),

/***/ 2:
/*!********************************************************************************************************************************************!*\
  !*** multi ./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css ./node_modules/bootstrap/dist/css/bootstrap.min.css ./src/styles.css ***!
  \********************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! C:\Users\Matheus\Desktop\ProAgil-dotnet-core\ProAgil-App\node_modules\ngx-bootstrap\datepicker\bs-datepicker.css */"./node_modules/ngx-bootstrap/datepicker/bs-datepicker.css");
__webpack_require__(/*! C:\Users\Matheus\Desktop\ProAgil-dotnet-core\ProAgil-App\node_modules\bootstrap\dist\css\bootstrap.min.css */"./node_modules/bootstrap/dist/css/bootstrap.min.css");
module.exports = __webpack_require__(/*! C:\Users\Matheus\Desktop\ProAgil-dotnet-core\ProAgil-App\src\styles.css */"./src/styles.css");


/***/ })

},[[2,"runtime"]]]);
//# sourceMappingURL=styles-es5.js.map