console.log(randRut())

function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max-min) + min);
}

function randRut(){
    let randNum = getRandomInt(1000000,100000000);
    let numberString = randNum.toString();
    return addDot(numberString) + '-' + getDigit(numberString);
}

function getDigit(numberString){
    let count = 11 - getSum(numberString) % 11;
    if (count == 10) {
        return 'K';
    }
    else {
        return count.toString();
    }
}

function getSum(numberString, sum = 0){
    let length = numberString.length
    let multiplier = length + 1
    if (length == 1) {
        return sum + parseInt(numberString) * multiplier
    }
    else if (length < 7) {
        return getSum(numberString.slice(1,length), parseInt(numberString[0] * multiplier) + sum);
    }
    else {
        return getSum(numberString.slice(0, length - 6)) + getSum(numberString.slice(-6))
    }
}

function addDot(numberString) {
    let numberArray = numberString.split('').reverse();
    let dottedRut = []
    for(number in numberArray) {
        if (number%3 == 0 && number > 0){
            dottedRut.push('.');
        }
        dottedRut.push(numberArray[number]);
    }
    return dottedRut.reverse().join('');
}
