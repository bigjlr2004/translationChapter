// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

const number = (dieString) => {
  switch (dieString) {
    case 1:
      answer = "one";
      break;
    case 2:
      answer = "two";
      break;
    case 3:
      answer = "three";
      break;
    case 4:
      answer = "four";
      break;
    case 5:
      answer = "five";
      break;
    case 6:
      answer = "six";
      break;
  }
  return answer;
};

for (let i = 0; i < 10; i++) {
  const dice1 = getRandomInt(1, 6);
  const dice2 = getRandomInt(1, 6);
  //   console.log(dice1);
  //   console.log(dice2);
  console.log(`${number(dice1)} + ${number(dice2)} ==  ${dice1 + dice2}`);
}
