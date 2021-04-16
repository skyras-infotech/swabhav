"use strict";
exports.__esModule = true;
var CricketCoach_1 = require("./CricketCoach");
var GolfCoach_1 = require("./GolfCoach");
var cc = new CricketCoach_1.CricketCoach();
var gc = new GolfCoach_1.GolfCoach();
var coachArray = [];
coachArray.push(cc);
coachArray.push(gc);
coachArray.forEach(function (element) {
    console.log(element.getDailyWorkout());
});
