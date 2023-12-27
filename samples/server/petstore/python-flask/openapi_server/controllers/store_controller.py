import connexion
import six
from typing import Dict
from typing import Tuple
from typing import Union

from openapi_server.models.order import Order  # noqa: E501
from openapi_server import util
from openapi_server.controllers.internal.i_store_controller import *


def delete_order(order_id):  # noqa: E501
    """Delete purchase order by ID

    :param order_id: ID of the order that needs to be deleted
    :type order_id: str

    :rtype: Union[None, Tuple[None, int], Tuple[None, int, Dict[str, str]]
    """
    return i_delete_order(order_id)


def get_inventory():  # noqa: E501
    """Returns pet inventories by status


    :rtype: Union[Dict[str, int], Tuple[Dict[str, int], int], Tuple[Dict[str, int], int, Dict[str, str]]
    """
    return i_get_inventory()


def get_order_by_id(order_id):  # noqa: E501
    """Find purchase order by ID

    :param order_id: ID of pet that needs to be fetched
    :type order_id: int

    :rtype: Union[Order, Tuple[Order, int], Tuple[Order, int, Dict[str, str]]
    """
    return i_get_order_by_id(order_id)


def place_order(body):  # noqa: E501
    """Place an order for a pet

    :param body: order placed for purchasing the pet
    :type body: dict | bytes

    :rtype: Union[Order, Tuple[Order, int], Tuple[Order, int, Dict[str, str]]
    """
    if connexion.request.is_json:
        body = Order.from_dict(connexion.request.get_json())  # noqa: E501
    return i_place_order(body)
