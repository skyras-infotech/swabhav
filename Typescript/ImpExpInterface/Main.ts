import { Coach } from "./Coach";
import { CricketCoach } from "./CricketCoach";
import { GolfCoach } from "./GolfCoach";

let cc = new CricketCoach();
let gc = new GolfCoach();

let coachArray: Coach[] = [];
coachArray.push(cc);
coachArray.push(gc);

coachArray.forEach(element => {
    console.log(element.getDailyWorkout());
});