import connexion
import six
from typing import Dict
from typing import Tuple
from typing import Union

from openapi_server.models.user import User  # noqa: E501
from openapi_server import util
from openapi_server.controllers.internal.i_user_controller import *


def create_user(body):  # noqa: E501
    """Create user

    :param body: Created user object
    :type body: dict | bytes

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    if connexion.request.is_json:
        body = User.from_dict(connexion.request.get_json())  # noqa: E501
    return i_create_user(body)


def create_users_with_array_input(body):  # noqa: E501
    """Creates list of users with given input array

    :param body: List of user object
    :type body: list | bytes

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    if connexion.request.is_json:
        body = [User.from_dict(d) for d in connexion.request.get_json()]  # noqa: E501
    return i_create_users_with_array_input(body)


def create_users_with_list_input(body):  # noqa: E501
    """Creates list of users with given input array

    :param body: List of user object
    :type body: list | bytes

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    if connexion.request.is_json:
        body = [User.from_dict(d) for d in connexion.request.get_json()]  # noqa: E501
    return i_create_users_with_list_input(body)


def delete_user(username):  # noqa: E501
    """Delete user

    :param username: The name that needs to be deleted
    :type username: str

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    return i_delete_user(username)


def get_user_by_name(username):  # noqa: E501
    """Get user by user name

    :param username: The name that needs to be fetched. Use user1 for testing.
    :type username: str

    :rtype: Union[User, Tuple[User, int], Tuple[User, int, Dict[str, str]]
    """
    return i_get_user_by_name(username)


def login_user(username, password):  # noqa: E501
    """Logs user into the system

    :param username: The user name for login
    :type username: str
    :param password: The password for login in clear text
    :type password: str

    :rtype: Union[str, Tuple[str, int], Tuple[str, int, Dict[str, str]]
    """
    return i_login_user(username, password)


def logout_user():  # noqa: E501
    """Logs out current logged in user session


    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    return i_logout_user()


def update_user(username, body):  # noqa: E501
    """Updated user

    :param username: name that need to be deleted
    :type username: str
    :param body: Updated user object
    :type body: dict | bytes

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    if connexion.request.is_json:
        body = User.from_dict(connexion.request.get_json())  # noqa: E501
    return i_update_user(username, body)
