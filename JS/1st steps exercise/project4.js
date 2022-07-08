function readingtime(input){
    let pages = Number(input[0])
    let pagesPerHour = Number(input[1])
    let days = Number(input[2])

    let totalTime = (pages / pagesPerHour) / days
    console.log(totalTime)
}

readingtime(["212 ",
"20 ",
"2 "]
)