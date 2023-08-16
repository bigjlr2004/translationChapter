// Put your code here

console.log("My enemies list!!!!");

console.log("-------------------");

const createEnemey = (firstName, lastName, offenses, isReallyHated) => {
  return {
    firstName: firstName,
    lastName: lastName,
    isReallyHated: isReallyHated,
    offenses: offenses,
    addoffenses: (offenses) => {
      this.offenses.push(offenses);
    },
  };
};

const JoshuaFlowers = createEnemey(
  "Joshua",
  "Flowers",
  [
    "Being a jerk to me in elementary school",
    "Not being nice to me in elementary school",
  ],
  true
);
const DarthVader = createEnemey(
  "Darth",
  "Vader",
  [
    "Cut off Luke's hand",
    "Murdered all those kids",
    "Unkind management practices",
  ],
  false
);

const frenemies = [DarthVader, JoshuaFlowers];

for (let frenemy of frenemies) {
  if (frenemy.isReallyHated)
    console.log(`${frenemy.firstName} ${frenemy.lastName}`);
}
console.log(frenemies);
