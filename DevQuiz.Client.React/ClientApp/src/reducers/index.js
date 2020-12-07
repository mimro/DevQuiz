import { combineReducers } from "redux";
import quizListReducer from "./quizListReducer";
import quizReducer from "./quizReducer";


const rootReducer = combineReducers({
    quizList: quizListReducer,
    quiz: quizReducer
});

export default rootReducer;