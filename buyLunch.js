// You are going to write a function which will select a random name from
// a list of names. The person selected will have to pay for everybody's food bill.

// ['debbie', 'mum', 'dad', 'sister', 'brother', 'friend'];

function whosPaying(names) {
  const numberOfPeople = names.length;
  const randomPersonPosition = Math.floor(Math.random() * numberOfPeople);
  const randomPerson = names[randomPersonPosition];
  console.log(randomPerson + " is buying us lunch today.");
  return randomPerson + " is buying us lunch today.";
}

whosPaying(["debbie", "mum", "dad", "sister", "brother", "friend"]);
