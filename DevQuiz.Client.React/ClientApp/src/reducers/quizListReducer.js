
const quizListReducer = (state = [], action) => {

    switch (action.type) {
        case 'FETCH_QUIZ_LIST_SUCCESS':
            return action.payload.quizList
        default:
            return state
    }
}

export default quizListReducer