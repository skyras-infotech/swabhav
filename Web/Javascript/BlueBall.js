function generateBalls() {
    let str = "";
    for (let i = 1; i <= 50; i++) {
        if (i == 1 || i == 11 || i == 21 || i == 31 || i == 41) {
            str += "<tr>";
        }
        str += "<td><p class=\"circle\" value=\"" + i + "\">" + i + "</p></td>";
        if (i == 10 || i == 20 || i == 30 || i == 40 || i == 50) {
            str += "</tr>";
        }
    }
    return str;
}

function play() {
    let x = document.getElementById("btnPlay").innerHTML;
    if (x == "Play") {
        document.getElementById("demo").innerHTML = generateBalls();
        document.getElementById("rules").innerHTML = "";
        document.getElementById("btnPlay").innerHTML = "Stop";
        startPlay();
    }
    else if (x == "Stop") {
        location.reload();
    }
}

function startPlay() {
    var guessNumber = Math.floor((Math.random() * 50) + 1);

    var numberOfGuesses = 0;
    document.querySelectorAll("p").forEach((item) => {
        item.addEventListener("click", function () {
            numberOfGuesses++;
            if (item.innerHTML > guessNumber) {
                item.style.backgroundColor = "green";
                item.style.color = "white";
            }
            else if (item.innerHTML < guessNumber) {
                item.style.backgroundColor = "red";
                item.style.color = "white";
            }
            else if (item.innerHTML == guessNumber) {
                item.style.backgroundColor = "blue";
                item.style.color = "white";
                setTimeout(Winning, 500);
            }
            if (numberOfGuesses == 3) {
                setTimeout(Lossing, 500);
            }
        });
    });

    function Lossing() {
        alert("Sorry your turn is over! The number was " + guessNumber + ". Please play again")
        location.reload();
    }

    function Winning() {
        alert("Congratulation! you won the game!")
        location.reload();
    }
}