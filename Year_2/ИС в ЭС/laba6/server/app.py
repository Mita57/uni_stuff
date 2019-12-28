from flask import Flask, jsonify, request, Response
from flask_cors import CORS


app = Flask(__name__)
CORS(app)


@app.route('/login', methods=['POST'])
def login():
    """
    Gets the data from the login form and authorizes the input

    Returns: JSON with auth result info
    """
    data = request.get_json()
    email = data.get('email')
    password = data.get('password')
    user = User.get_by_attrs(('nickname', 'password'), 'email', email)
    user_pw = user[0][1]
    user_nick = user[0][0]
    if password == user_pw:
        return jsonify(result=user_nick)
    else:
        return jsonify(result='fail')


if __name__ == '__main__':
    app.run(debug=True)
