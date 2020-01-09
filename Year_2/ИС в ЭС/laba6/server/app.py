from flask import Flask, jsonify, request, Response
from flask_cors import CORS
from models.BasicModel import SQLModel

app = Flask(__name__)
CORS(app)


@app.route('/login', methods=['POST'])
def login():
    """
    Gets the data from the login form and authorizes the input

    Returns: JSON with auth result info
    """
    data = request.get_json()
    try:
        id = data.get('id')
        password = data.get('password')
        user = SQLModel.get_by_attrs('*', 'users', 'id', id)
        user_pw = user[0][1]
        user_id = user[0][0]
        if password == user_pw:
            return jsonify(result=user_id)
        else:
            return jsonify(result='fail')
    except:
        return jsonify(result='fail')

@app.route("/getInfo")
def get_info():
    table = request.args.get('table')
    response = SQLModel.get_by_attrs('*', table, 1, 1)


if __name__ == '__main__':
    app.run(debug=True)
