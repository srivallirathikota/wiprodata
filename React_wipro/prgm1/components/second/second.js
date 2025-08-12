import React, {Component} from 'react';

const Second =()=>{
     return (
      <div>second Component</div>
     )
}
export default Second;






// import './second.scss'
// // import { connect } from "react-redux";
// // import { bindActionCreators } from "redux";
// // import * as secondActions from "../../store/second/actions";
// export default class second extends Component {
//     // constructor(props) {
//     //     super(props);
//     //     this.state = {};
//     // }
//     render() {
//       return <div className="component-second">Hello! component second</div>;
//     }
//   }
// // export default connect(
// //     ({ second }) => ({ ...second }),
// //     dispatch => bindActionCreators({ ...secondActions }, dispatch)
// //   )( second );