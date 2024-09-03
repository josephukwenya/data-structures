const calculator = (num1, num2, operator) => {
  switch (operator) {
    case '+':
      return num1 + num2;
      break;
    case '-':
      return num1 - num2;
      break;
    case '*':
      return num1 * num2;
      break;
    case '/':
      return num1 / num2;
      break;
    default:
      throw new Error('Invalid operator');
  }
};

console.log(calculator(2, 3, '+'));
