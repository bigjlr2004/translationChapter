// Put your code here

console.log("So do you believe in Magic?");
console.log("---------------------------");

const createSpell = (spellName, isEvil, energyRequired) => {
  return {
    spellName: spellName,
    isEvil: isEvil,
    energyRequired: energyRequired,
  };
};
const createGoodSpellBook = (spells) => {
  return {
    bookName: "Good Spell Book",
    selectedSpells: spells.filter((p) => !p.isEvil),
  };
};
const createEvilSpellBook = (spells) => {
  return {
    bookName: "Evil Spell Book",
    selectedSpells: spells.filter((p) => p.isEvil),
  };
};
const displaySpells = (spellBook) => {
  console.log(spellBook.bookName);
  for (spell of spellBook.selectedSpells) {
    console.log(`   ${spell.spellName}`);
  }
};

const allSpells = [
  createSpell("Turn enemy into a newt", true, 5.1),
  createSpell("Conjure some gold for charity", false, 2.99),
  createSpell("Give a deaf person the ability to heal", false, 12.2),
  createSpell("Make yourself emperor of the universe", true, 100.0),
  createSpell(
    "Convince your relatives that your political reviews are correct",
    false,
    2921.5
  ),
];

console.log(allSpells);
console.log(createGoodSpellBook(allSpells));
console.log(createEvilSpellBook(allSpells));
displaySpells(createGoodSpellBook(allSpells));
displaySpells(createEvilSpellBook(allSpells));
